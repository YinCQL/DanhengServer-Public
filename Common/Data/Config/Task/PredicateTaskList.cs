﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Data.Config.Task
{
    public class PredicateTaskList : TaskConfigInfo
    {
        public PredicateConfigInfo Predicate { get; set; } = new();
        public List<TaskConfigInfo> SuccessTaskList { get; set; } = [];
        public List<TaskConfigInfo> FailedTaskList { get; set; } = [];

        public static new TaskConfigInfo LoadFromJsonObject(JObject obj)
        {
            PredicateTaskList info = new();
            info.Type = obj[nameof(Type)]!.ToObject<string>()!;
            if (obj.ContainsKey(nameof(Predicate)))
            {
                info.Predicate = (PredicateConfigInfo.LoadFromJsonObject((obj[nameof(Predicate)] as JObject)!)!);
            }

            if (obj.ContainsKey(nameof(SuccessTaskList)))
            {
                info.SuccessTaskList = obj[nameof(SuccessTaskList)]?.Select(x => TaskConfigInfo.LoadFromJsonObject((x as JObject)!)).ToList() ?? [];
            }

            if (obj.ContainsKey(nameof(FailedTaskList)))
            {
                info.FailedTaskList = obj[nameof(FailedTaskList)]?.Select(x => TaskConfigInfo.LoadFromJsonObject((x as JObject)!)).ToList() ?? [];
            }
            return info;
        }
    }
}
