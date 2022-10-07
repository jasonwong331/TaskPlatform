using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jason.TaskPlatform.Entitys
{
    public class Task
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName
        {
            get; set;
        }

        //任务
        public string TaskId
        {
            get; set;
        }

        //任务类型
        public string TaskType
        {
            get; set;
        }

        //任务状态
        public string TaskStatus
        {
            get; set;
        }

        //任务描述
        public string TaskDescription
        {
            get; set;
        }

        //任务创建时间
        public DateTime TaskCreateTime
        {
            get; set;
        }

        //任务开始时间
        public DateTime TaskStartTime
        {
            get; set;
        }

        //任务结束时间
        public DateTime TaskEndTime
        {
            get; set;
        }

        //任务执行时间
        public DateTime TaskExecuteTime
        {
            get; set;
        }

        //任务执行次数
        public int TaskExecuteCount
        {
            get; set;
        }

        //任务执行间隔
        public int TaskExecuteInterval
        {
            get; set;
        }

        //任务执行参数
        public string TaskExecuteParameter
        {
            get; set;
        }

        //任务执行结果
        public string TaskExecuteResult
        {
            get; set;
        }

        //任务执行结果描述
        public string TaskExecuteResultDescription
        {
            get; set;
        }

        //任务执行结果时间
        public DateTime TaskExecuteResultTime
        {
            get; set;
        }

        //任务执行结果状态
        public string TaskExecuteResultStatus
        {
            get; set;
        }

        //任务执行结果状态描述
        public string TaskExecuteResultStatusDescription
        {
            get; set;
        }

        //任务执行结果状态时间
        public DateTime TaskExecuteResultStatusTime
        {
            get; set;
        }

        //任务执行结果状态次数
        public int TaskExecuteResultStatusCount
        {
            get; set;
        }

        //任务执行结果状态间隔
        public int TaskExecuteResultStatusInterval
        {
            get; set;
        }

        //任务执行结果状态参数
        public string TaskExecuteResultStatusParameter
        {
            get; set;
        }

        //任务执行结果状态结果
        public string TaskExecuteResultStatusResult
        {
            get; set;
         }

    }
}
