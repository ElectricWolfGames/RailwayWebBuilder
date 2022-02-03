namespace RailwayWebBuilderCore.Interfaces
{
    public interface ILocomotiveSpecifications
    {
        string Designer { get; }
        string Builder { get; }
        string BuildRange { get; }
        int TotalProduced { get; }
    }
}