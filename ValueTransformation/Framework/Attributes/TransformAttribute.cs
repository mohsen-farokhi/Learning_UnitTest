using System;

namespace ValueTransformation.Framework.Attributes
{
    public class TransformAttribute : Attribute
    {
        public TransformAttribute(TransformType transformType = TransformType.String)
        {
            Type = transformType;
        }

        public TransformType Type { get; }

    }
}
