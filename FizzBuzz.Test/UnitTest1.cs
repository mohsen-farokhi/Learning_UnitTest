using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Returns_numbers_when_not_divided_by_3_or_5()
        {
            var result = FizzBuzzGenerator.Generate(1, 2);
        }
    }

    public class FizzBuzzGenerator
    {
        public static IList<string> Generate(int start, int end)
        {
            return null;
        }
    }
}
