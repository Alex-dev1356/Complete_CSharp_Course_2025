using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercises
{
    public class OOP_DogClass
    {
        public string Name;
        public string Breed;
        public int Weight;

        public OOP_DogClass(string name, string breed, int weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public OOP_DogClass(string name, int weight) : this(name, "mixed-breed", weight)
        {
        }

        public string Describe()
        {
            string size = "";


            return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {DescribeSize()} dog.";
        }

        public string DescribeSize()
        {
            switch (Weight)
            {
                case < 5:
                    return "tiny";

                case < 30:
                    return "medium";

                default:
                    return "large";

            }
        }
    }
}
