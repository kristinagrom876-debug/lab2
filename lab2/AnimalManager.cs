using System;
using System.Collections.Generic;

namespace ZooApp
{
  sealed class AnimalManager
  {
    private static readonly AnimalManager instance = new AnimalManager();
    public static AnimalManager Instance => instance;

    private List<Animal> animals = new List<Animal>();

    private AnimalManager() { }

    public void AddAnimal(Animal animal)
    {
      animals.Add(animal);
    }

    public void ShowAllAnimals()
    {
      if (animals.Count == 0)
      {
        Console.WriteLine("No animals.");
        return;
      }
      for (int index = 0; index < animals.Count; ++index)
      {
        Console.WriteLine($"[{index}] {animals[index].GetInfo()}");
      }
    }

    public void ShowAnimalByIndex(int index)
    {
      if (index >= 0 && index < animals.Count)
      {
        Console.WriteLine(animals[index].GetInfo());
      }
      else
      {
        Console.WriteLine("Invalid index.");
      }
    }

    public void ShowAnimalByName(string name)
    {
      foreach (Animal animal in animals)
      {
        if (animal.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine(animal.GetInfo());
          return;
        }
      }
      Console.WriteLine($"Animal '{name}' not found.");
    }
  }
}