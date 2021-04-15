﻿using RailwayWebBuilderCore.Interfaces;
using System;
using System.Text;

namespace RailwayWebBuilderCore.Builders.MyLayouts.Details
{
    public abstract class LayoutBase : ILayoutPagesDetails
    {
        public bool Active { get; set; } = true;
        public StringBuilder Details { get; set; }
        public string ExportImagePath { get; set; }
        public string RawImagePath { get; set; }
        public string Title { get; set; }
        public DateTime When { get; set; }
        public string YouTubeLink { get; set; }
    }
}