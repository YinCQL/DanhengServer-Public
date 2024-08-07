﻿using EggLink.DanhengServer.Data;
using EggLink.DanhengServer.Game.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.GameServer.Game.Task
{
    public class SceneTaskTrigger(PlayerInstance player)
    {
        public PlayerInstance Player { get; } = player;

        public void TriggerFloor(int planeId, int floorId)
        {
            GameData.GetFloorInfo(planeId, floorId, out var floor);
            if (floor == null) return;
            
            foreach (var group in floor.Groups.Values)
            {
                if (group.LevelGraphConfig == null) continue;
                foreach (var task in group.LevelGraphConfig.OnInitSequece)
                {
                    Player.TaskManager?.LevelTask.TriggerInitAct(task, new(), group);
                }

                foreach (var task in group.LevelGraphConfig.OnStartSequece)
                {
                    Player.TaskManager?.LevelTask.TriggerStartAct(task, new(), group);
                }
            }
        }

        public void TriggerGroup(int planeId, int floorId, int groupId)
        {
            GameData.GetFloorInfo(planeId, floorId, out var floor);
            if (floor == null) return;
            if (floor.Groups.TryGetValue(groupId, out var group))
            {
                if (group.LevelGraphConfig == null) return;
                foreach (var task in group.LevelGraphConfig.OnInitSequece)
                {
                    Player.TaskManager?.LevelTask.TriggerInitAct(task, new(), group);
                }

                foreach (var task in group.LevelGraphConfig.OnStartSequece)
                {
                    Player.TaskManager?.LevelTask.TriggerStartAct(task, new(), group);
                }
            }
        }
    }
}
