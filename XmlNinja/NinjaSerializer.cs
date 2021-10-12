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

            xmlBuiler.Append(openTagFor(nameOfClass));

            var properties = target.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                var nameOfProperty = propertyInfo.Name;
                var value = propertyInfo.GetValue(target);

                xmlBuiler.Append(getTag(nameOfProperty, value));
            }

            xmlBuiler.Append(closeTagFor(nameOfClass));

            return xmlBuiler.ToString();
        }

        private static string getTag(string tag, object value)
        {
            return $"{openTagFor(tag)}{value}{closeTagFor(tag)}";
        }

        private static string openTagFor(string tag)
        {
            return $"<{tag}>";
        }

        private static string closeTagFor(string tag)
        {
            return $"</{tag}>";
        }
    }
}
