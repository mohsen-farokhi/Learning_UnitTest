using FluentAssertions;
using System;
using Xunit;

namespace XmlNinja.Test
{
    public class NinjaSerializerTests
    {
        [Fact]
        public void Serialize_empty_tag_for_empty_object()
        {
            var customer = new Customer();
            var expected = "<Customer></Customer>";

            var serialized = NinjaSerializer.Serialize(customer);

            serialized.Should().Be(expected);
        }

        [Fact]
        public void Serialize_empty_string_for_null_value()
        {
            var serialized = NinjaSerializer.Serialize(null);

            serialized.Should().BeEmpty();
        }

        [Fact]
        public void Serialize_flat_object()
        {
            var person = 
                new Person(firstName: "John", lastName: "Doe");

            var extected = 
                "<Person>" +
                    "<FirstName>John</FirstName>" +
                    "<LastName>Doe</LastName>" +
                "</Person>";

            var serialized = NinjaSerializer.Serialize(person);

            serialized.Should().Be(extected);
        }

    }
}
