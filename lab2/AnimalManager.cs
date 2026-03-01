using System;
using System.Collections.Generic;

namespace ZooApp {
  class AnimalManager {
    private static AnimalManager _instance;

    public static AnimalManager Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new AnimalManager();
        }
        return _instance;
      }
    }

    private List<Animal> animals;

    private AnimalManager()
    {
      animals = new List<Animal>();
    }

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
        if (animal.name.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
          Console.WriteLine(animal.GetInfo());
          return;
        }
      }
      Console.WriteLine($"Animal '{name}' not found.");
    }
  }
}