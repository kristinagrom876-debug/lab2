using System;

namespace ZooApp
{
  class Program
  {
    static void Main()
    {
      AnimalManager manager = AnimalManager.Instance;

      manager.AddAnimal(new Mammal("Like", 5, "savanna", "carnivore", true));
      manager.AddAnimal(new Bird("Tweety", 2, "forest", "herbivore", 0.25));
      manager.AddAnimal(new Fish("Nemo", 1, "ocean", "omnivore", "saltwater"));
      manager.AddAnimal(new Reptile("Rango", 3, "desert", "insectivore", false));
      manager.AddAnimal(new Amphibian("Gorge", 4, "swamp", "omnivore", "moist"));

      Console.WriteLine("Welcome to the Zoo Manager!");

      bool isRunning = true;

      string choice, type, name, habitat, diet, waterType, skinMoisture;
      int age, index;
      bool hasFur, isVenomous;
      double wingSpan;

      while (isRunning)
      {
        Console.WriteLine("\nMENU:");
        Console.WriteLine("1. Add new animal");
        Console.WriteLine("2. Show all animals");
        Console.WriteLine("3. Show animal by index");
        Console.WriteLine("4. Show animal by name");
        Console.WriteLine("5. Exit");
        Console.Write("Choose option: ");

        choice = Console.ReadLine();

        if (choice == "1")
        {
          Console.WriteLine("\nSelect animal type:");
          Console.WriteLine("1. Mammal");
          Console.WriteLine("2. Bird");
          Console.WriteLine("3. Fish");
          Console.WriteLine("4. Reptile");
          Console.WriteLine("5. Amphibian");
          Console.Write("Enter number (1-5): ");
          type = Console.ReadLine();

          Console.Write("Name: ");
          name = Console.ReadLine();
          Console.Write("Age: ");
          age = Convert.ToInt32(Console.ReadLine());
          Console.Write("Habitat: ");
          habitat = Console.ReadLine();
          Console.Write("Diet: ");
          diet = Console.ReadLine();

          if (type == "1")
          {
            Console.Write("Has fur? (yes/no): ");
            hasFur = Console.ReadLine() == "yes";
            manager.AddAnimal(new Mammal(name, age, habitat, diet, hasFur));
            Console.WriteLine("Animal added!");
          }
          else if (type == "2")
          {
            Console.Write("Wingspan (m): ");
            wingSpan = Convert.ToDouble(Console.ReadLine());
            manager.AddAnimal(new Bird(name, age, habitat, diet, wingSpan));
            Console.WriteLine("Animal added!");
          }
          else if (type == "3")
          {
            Console.Write("Water type (fresh/salt): ");
            waterType = Console.ReadLine();
            manager.AddAnimal(new Fish(name, age, habitat, diet, waterType));
            Console.WriteLine("Animal added!");
          }
          else if (type == "4")
          {
            Console.Write("Is venomous? (yes/no): ");
            isVenomous = Console.ReadLine() == "yes";
            manager.AddAnimal(new Reptile(name, age, habitat, diet, isVenomous));
            Console.WriteLine("Animal added!");
          }
          else if (type == "5")
          {
            Console.Write("Skin moisture (moist/dry): ");
            skinMoisture = Console.ReadLine();
            manager.AddAnimal(new Amphibian(name, age, habitat, diet, skinMoisture));
            Console.WriteLine("Animal added!");
          }
          else
          {
            Console.WriteLine("Wrong type!");
          }
        }
        else if (choice == "2")
        {
          manager.ShowAllAnimals();
        }
        else if (choice == "3")
        {
          Console.Write("Enter index: ");
          index = Convert.ToInt32(Console.ReadLine());
          manager.ShowAnimalByIndex(index);
        }
        else if (choice == "4")
        {
          Console.Write("Enter name: ");
          name = Console.ReadLine();
          manager.ShowAnimalByName(name);
        }
        else if (choice == "5")
        {
          Console.WriteLine("Goodbye!");
          break;
        }
        else
        {
          Console.WriteLine("Wrong choice! Try again.");
        }
      }
    }
  }
}