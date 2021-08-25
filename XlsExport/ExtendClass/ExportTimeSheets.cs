using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsExport.ExtendClass
{
    /// <summary>
    /// 列车信息
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
        /// 列车经过所有
        /// </summary>
        public List<int> StopsIds { get; set; }
        public List<int> RunIds { get; set; }
        public List<int> StationsEids { get; set; }
    }

    public partial class StationInfo
    {
        public StationInfo()
        {
            TrainIds = new List<int>();
        }

        public int StationsEid { get; set; }
        public string StationName { get; set; }
        public string TrackName { get; set; }
        public string ArrTime { get; set; }
        public string DepTime { get; set; }
        public List<int> TrainIds { get; set; }
    }
}
