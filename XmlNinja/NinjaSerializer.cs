using System;
using System.Text;

namespace XmlNinja
{
    public class NinjaSerializer
    {
        public static string Serialize(object target)
        {
            if (target == null)
            {
                return string.Empty;
            }

            var xmlBuiler = new StringBuilder();

            var nameOfClass = target.GetType().Name;

            xmlBuiler.Append(OpenTagFor(nameOfClass));

            var properties = target.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                var nameOfProperty = propertyInfo.Name;
                var value = propertyInfo.GetValue(target);

                xmlBuiler.Append(GetTag(nameOfProperty, value));
            }

            xmlBuiler.Append(CloseTagFor(nameOfClass));

            return xmlBuiler.ToString();
        }

        private static string GetTag(string tag, object value)
        {
            return $"{OpenTagFor(tag)}{value}{CloseTagFor(tag)}";
        }

        private static string OpenTagFor(string tag)
        {
            return $"<{tag}>";
        }

        private static string CloseTagFor(string tag)
        {
            return $"</{tag}>";
        }
    }
}
