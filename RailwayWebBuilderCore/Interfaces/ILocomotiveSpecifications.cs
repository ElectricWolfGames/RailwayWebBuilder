namespace RailwayWebBuilderCore.Interfaces;

public interface ILocomotiveSpecifications
{
    string Builder { get; }
    string BuildRange { get; }
    string Designer { get; }
    int TotalProduced { get; }
}