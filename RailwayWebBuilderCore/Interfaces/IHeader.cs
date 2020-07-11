using System.Collections.Generic;

namespace RailwayWebBuilder.Interfaces
{
    public interface IHeader
    {
        string Title { get; set; }
        List<string> Keywords { get; set; }
        string MetaDetails { get; set; }
    }
}
