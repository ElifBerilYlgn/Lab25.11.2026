using System;

class Animal
{
    public string Name = "";
    public int Age;

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Dog : Animal
{
    public string Breed = "";

    public void Fetch()
    {
        Console.WriteLine($"{Name} brings ball back!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Name = "Karabas";
        dog.Age = 3;
        dog.Breed = "Kangal";

        dog.Eat();
        dog.Fetch();

        Console.WriteLine(
            $"{dog.Name} ({dog.Breed}), {dog.Age} years old"
        );
    }
}