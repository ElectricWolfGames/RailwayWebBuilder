using System.Collections.Generic;

namespace RailwayWebBuilderCore.Data.GCR
{
    public class GCRTimetable
    {
        public List<GCRTimetableStation> TimetableStation = new List<GCRTimetableStation>();
    }

    public class GCRTimetableStation
    {
        public List<string> DownLine = new List<string>();
        public List<string> UpLine = new List<string>();
        public string Name { get; set; }
    }
}