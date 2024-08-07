﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Database.Inventory;
using EggLink.DanhengServer.Proto;
using EggLink.DanhengServer.Server.Packet.Send.Challenge;
using EggLink.DanhengServer.Server.Packet.Send.Gacha;
using EggLink.DanhengServer.Server.Packet.Send.Shop;
using EggLink.DanhengServer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Recv.Shop
{
    [Opcode(CmdIds.DoGachaInRollShopCsReq)]
    public class HandlerDoGachaInRollShopCsReq : Handler
    {
        public override void OnHandle(Connection connection, byte[] header, byte[] data)
        {
            var req = DoGachaInRollShopCsReq.Parser.ParseFrom(data);
            ItemList itemList = new();
            var count = req.JLLODFFJGDM;
            uint maxtype = 3;
            for (uint i = 0; i < count; i++)
            {
                Dictionary<uint, uint> GroupIds = new();
                Dictionary<uint, uint> RewardIds = new();

                GameData.RollShopConfigData.Values.ToList().ForEach(x =>
                {
                    if (x.RollShopID == req.RollShopId)
                    {
                        GroupIds.Add(x.T1GroupID,1);
                        GroupIds.Add(x.T2GroupID,2);
                        GroupIds.Add(x.T3GroupID,3);
                        GroupIds.Add(x.T4GroupID,4);
                    }
                });
                GameData.RollShopRewardData.Values.ToList().ForEach(x =>
                { 
                    GroupIds.Keys.ToList().ForEach(y =>
                    {
                        if (x.GroupID == y)
                        {
                            RewardIds.Add(x.RewardID, GroupIds[y]);
                        }
                    });
                });
                var RewardId = RewardIds.Keys.ToList().RandomElement();
                var type = RewardIds[RewardId];
                if (type < maxtype) maxtype = type;
                var rewardExcel = GameData.RewardDataData[(int)RewardId];
                var rewardItems = rewardExcel.GetItems();
                var itemData = new ItemData()
                {
                    ItemId = rewardItems[0].Item1,
                    Count = rewardItems[0].Item2
                };
                var rsp = connection.Player!.InventoryManager!.AddItem(itemData.ItemId, itemData.Count);
                if (rsp != null)
                {
                    itemList.ItemList_.Add(rsp.ToProto());
                }
                connection.Player!.InventoryManager!.RemoveItem(122000, 1);
            }
            connection.SendPacket(new PacketDoGachaInRollShopScRsp(req.RollShopId, itemList, maxtype));
        }
    }
}