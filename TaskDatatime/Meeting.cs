using System;
using System.Collections.Generic;
using System.Text;

namespace TaskDatatime
{
    class Meeting
    {
        public Meeting(DateTime from, DateTime to, string fullname)
        {
            FromDate = from;
            ToDate = to;
            FullName = fullname;
        }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string FullName { get; set; }
    }
}
