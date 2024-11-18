using System.Collections.Generic;

namespace RailwayWebBuilderCore.Data.GCR
{
    public class GCRTimetable
    {
        public List<GCRTimetableStation> TimetableStation = new();
    }

    public class GCRTimetableStation
    {
        public List<string> DownLine = new();
        public List<string> UpLine = new();
        public string Name { get; set; }
    }
}