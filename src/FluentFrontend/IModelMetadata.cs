﻿namespace FluentFrontend
{
    public interface IModelMetadata
    {
        string PropertyName { get; }
        string NestedPropertyName { get; }
        string DisplayName { get; }
        string Description { get; }
        bool IsRequired { get; }
    }
}