using ValueTransformation.Framework.Attributes;

namespace ValueTransformation
{
    public class Person
    {
        public long Id { get; set; }

        [Transform]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Transform(TransformType.Email)]
        public string Email { get; set; }

        public string Website { get; set; }

        public string Address { get; set; }
    }
}
