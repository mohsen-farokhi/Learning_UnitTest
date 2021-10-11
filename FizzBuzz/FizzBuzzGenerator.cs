using System.Collections.Generic;

namespace FizzBuzz
{

    public class FizzBuzzGenerator
    {
        public static IList<string> Generate(int start, int end)
        {
            var result = new List<string>();

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add(Constants.FizzBuzz);
                }
                else if (i % 3 == 0)
                {
                    result.Add(Constants.Fizz);
                }
                else if (i % 5 == 0)
                {
                    result.Add(Constants.Buzz);
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}
