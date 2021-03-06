﻿namespace RailwayWebBuilder.Interfaces
{
    public interface IPageBuilder
    {
        void Build(IModelEvent pageDetails);

        string Jumbotron(IModelPageDetails pageDetails);
    }
}
