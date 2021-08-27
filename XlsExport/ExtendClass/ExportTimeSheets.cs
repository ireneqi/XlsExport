using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsExport.ExtendClass
{
    /// <summary>
    /// 打印列车信息
    /// </summary>
    public partial class TrainInfo
    {
        public TrainInfo()
        {
            RunIds = new List<int>();
            StopsIds = new List<int>();
            StationsEids = new List<int>();
        }
        /// <summary>
        /// 列车打印顺序
        /// </summary>
        public int TrainEid { get; set; }
        /// <summary>
        /// 列车车次号
        /// </summary>
        public string Linie { get; set; }
        /// <summary>
        /// 始发站
        /// </summary>
        public string OriginStation { get; set; }
        /// <summary>
        /// 终到站
        /// </summary>
        public string DestinationStation { get; set; }
        /// <summary>
        /// 列车经过所有车站ID
        /// </summary>
        public List<int> StopsIds { get; set; }
        /// <summary>
        /// 列车经过所有区间ID
        /// </summary>
        public List<int> RunIds { get; set; }
        /// <summary>
        /// 车站的打印ID
        /// </summary>
        public List<int> StationsEids { get; set; }
    }
    /// <summary>
    /// 打印车站信息
    /// </summary>
    public partial class StationInfo
    {
        public StationInfo()
        {
            TrainIds = new List<int>();
        }
        /// <summary>
        /// 车站打印ID
        /// </summary>
        public int StationsEid { get; set; }
        /// <summary>
        /// 车站名
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// 股道名称
        /// </summary>
        public string TrackName { get; set; }
        /// <summary>
        /// 车站到点
        /// </summary>
        public string ArrTime { get; set; }
        /// <summary>
        /// 车站发点
        /// </summary>
        public string DepTime { get; set; }
        /// <summary>
        /// 经过这个车站的列车Id
        /// </summary>
        public List<int> TrainIds { get; set; }
    }
    /// <summary>
    /// 车站区间信息
    /// </summary>
    public partial class SectionInfo
    {
        /// <summary>
        /// 区间距离
        /// </summary>
        public string Distance { get; set; }
        /// <summary>
        /// 区间运行时分
        /// </summary>
        public string RunTime { get; set; }
    } 
}
