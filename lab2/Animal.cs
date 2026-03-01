using System;

namespace ZooApp {
  abstract class Animal {
    public string name { get; private set; }
    public int age { get; private set; }
    public string habitat { get; private set; }
    public string diet { get; private set; }

    protected Animal(string animalName, int animalAge, string animalHabitat, string animalDiet) {
      name = animalName;
      age = animalAge;
      habitat = animalHabitat;
      diet = animalDiet;
    }

    public virtual string GetInfo() {
      return $"Name: {name}, Age: {age}, Habitat: {habitat}, Diet: {diet}";
    }
  }
}