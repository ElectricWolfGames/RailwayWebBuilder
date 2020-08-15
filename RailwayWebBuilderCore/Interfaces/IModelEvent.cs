using eWolfBootstrap.Interfaces;

namespace RailwayWebBuilderCore.Interfaces
{
    public interface IModelEvent : IPageHeader, IModelPageDetails
    {
        void Fix();

        void CopyLayoutsToKeywords();
    }
}
