﻿using System.Linq;
using ValueTransformation.Framework.Attributes;
using System.Reflection;
using ValueTransformation.Framework.ValueTransformers;

namespace ValueTransformation.Framework
{
    public static class ObjectTransformer
    {
        public static T Transform<T>(T input)
        {
            var propertiesToTransform = 
                typeof(T).GetProperties()
                .Where(c => c.GetCustomAttributes<TransformAttribute>().Any())
                .ToList();

            foreach (var propertyInfo in propertiesToTransform)
            {
                var attribute = propertyInfo.GetCustomAttribute<TransformAttribute>();
                var transformer = ValueTransformerFactory.Create(attribute);
                var newValue = transformer.Transform(propertyInfo.GetValue(input).ToString());
                propertyInfo.SetValue(input, newValue);
            }

            return input;
        }
    }
}
