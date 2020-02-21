using System;

namespace Dog
{
    
    public enum Gender
    {
        Male,
        Female
    }
    
    public class Dog
    {
        string name;
        string owner;
        int age;
        Gender gender;

        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark(int barks)
        {
            for(int i=0; i < barks; i++)
            {
                Console.WriteLine("Woof! ");
            }
        }

        public string getTag()
        {
            string tag;

            tag = $"If lost, call {owner}. ";

            if(gender==0)
            {
                tag = tag + ($"His name is {name} and he is {age}");
            }

            else
            {
                tag = tag + ($"Her name is {name} and she is {age}");
            }

            if(age==1)
            {
                tag = tag + (" year old.");
            }
            else
            {
                tag = tag + (" years old.");
            }
            
            return tag;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
puppy.Bark(3); // output: Woof!Woof!Woof!
Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
myDog.Bark(1); // output: Woof!
Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    }
}
