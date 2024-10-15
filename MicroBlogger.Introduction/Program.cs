// See https://aka.ms/new-console-template for more information
// anything goes here
//Console.WriteLine("Hey there world!");

/*string petName = "Baylee";
string petSpecies = "Dog";
int age = 16;
//Console.WriteLine(petName + " is a " + petSpecies + " and is " + age + " years old");
Console.WriteLine($"{petName} is a {petSpecies} and is {age} years old");

string catName = "Tiny Cat";
string catSpecies = "Cat";
int catAge = 11;
Console.WriteLine($"{catName} is a {catSpecies} and is {catAge} years old");*/

var pet = new Pet("Baylee", "Dog", 16);
var pet2 = new Pet("Baylee", "Dog", 16);

Console.WriteLine(pet.Equals(pet2));

//Console.WriteLine($"{pet.Name} is a {pet.Species} and is {pet.Age} years old");

var tinyCat = new Pet("Tiny Cat", "Cat", 11);

//Console.WriteLine($"{tinyCat.Name} is a {tinyCat.Species} and is {tinyCat.Age} years old");

tinyCat.HaveBirthday();

//Console.WriteLine($"{tinyCat.Name} is a {tinyCat.Species} and is {tinyCat.Age} years old");

Console.WriteLine(tinyCat);
Console.WriteLine(pet);

public record Pet(string Name, string Species)
{
    public int Age { get; private set; }

    public Pet(string name, string species, int age) : this(name, species)
    {
        Age = age;
    }

    public void HaveBirthday()
    {
        Age++;
    }
}

/*public class Pet
{
    public string Name { get; private set; }
    public string Species { get; private set; }
    public int Age { get; private set; }

    public Pet(string name, string species, int age)
    {
        Name = name;
        Species = species;
        Age = age;
    }

    public void HaveBirthday()
    {
        Age++;
    }

    public override string ToString()
    {
        return $"{Name} is a {Species} and is {Age} years old";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Pet otherPet)
        {
            return otherPet.Name == Name && otherPet.Age == Age && otherPet.Species == Species;
        }
        return false;
    }
}*/