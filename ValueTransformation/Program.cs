using FizzWare.NBuilder;
using System;
using ValueTransformation.Framework;

namespace ValueTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = Builder<Person>.CreateListOfSize(3)
            //    .All()
            //    .With(c => c.FirstName = Faker.Name.First())
            //    .With(c => c.LastName = Faker.Name.First())
            //    .With(c => c.Email = Faker.Internet.Email("jack"))
            //    .With(c => c.Address = Faker.Address.SecondaryAddress())
            //    .With(c => c.Website = Faker.Internet.DomainName())
            //    .Build();

            var person = new Person
            {
                Id = 1,
                FirstName = "Jack",
                LastName = "Smith",
                Email = "jack@yahoo.com",
            };

            var transfomed = 
                ObjectTransformer.Transform(person);
             


            Console.ReadLine();
        }
    }
}
