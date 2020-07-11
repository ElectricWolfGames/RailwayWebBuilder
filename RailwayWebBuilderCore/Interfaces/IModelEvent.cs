namespace RailwayWebBuilder.Interfaces
{
    public interface IModelEvent : IHeader, IModelPageDetails
    {
        void Fix();

        void CopyLayoutsToKeywords();
    }
}
