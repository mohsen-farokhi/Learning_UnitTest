using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzGeneratorTest
    {
        [Fact]
        public void Returns_numbers_when_not_divided_by_3_or_5()
        {
            var expected = new List<string>() { "1", "2" };

            var actual = FizzBuzzGenerator.Generate(start: 1, end: 2);

            actual.Should().BeEquivalentTo(expectation: expected);
        }

        [Fact]
        public void Puts_fizz_in_output_when_is_divided_by_3()
        {
            var expected = new List<string>() { "1", "2", Constants.Fizz };

            var actual = FizzBuzzGenerator.Generate(start: 1, end: 3);

            actual.Should().BeEquivalentTo(expectation: expected);
        }

        [Fact]
        public void Puts_buzz_in_output_when_number_is_divided_by_5()
        {
            var expected = new List<string>() { "4", Constants.Buzz };

            var actual = FizzBuzzGenerator.Generate(start: 4, end: 5);

            actual.Should().BeEquivalentTo(expectation: expected);
        }

        [Fact]
        public void Puts_fizzbuzz_in_output_when_number_is_divided_by_both_3_and_5()
        {
            var expected = new List<string>() { "13", "14", Constants.FizzBuzz, "16" };

            var actual = FizzBuzzGenerator.Generate(start: 13, end: 16);

            actual.Should().BeEquivalentTo(expectation: expected);
        }
    }
}
