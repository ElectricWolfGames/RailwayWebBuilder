using eWolfBootstrap.Interfaces;

namespace RailwayWebBuilder.Interfaces
{
    public interface IModelEvent : IPageHeader, IModelPageDetails
    {
        void Fix();

        void CopyLayoutsToKeywords();
    }
}
