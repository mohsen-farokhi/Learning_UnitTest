using ValueTransformation.Framework.Attributes;

namespace ValueTransformation.Framework.ValueTransformers
{
    public static class ValueTransformerFactory
    {
        public static IValueTransformer Create(TransformAttribute attribute)
        {
            switch (attribute.Type)
            {
                case TransformType.String:
                    return new StringTransformer();
                case TransformType.Email:
                    return new EmailTransformer();
                default:
                    throw new System.NotSupportedException();
            }
        } 
    }
}
