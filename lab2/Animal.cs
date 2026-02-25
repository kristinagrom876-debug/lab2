using System;

namespace ZooApp {
  abstract class Animal {
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Habitat { get; private set; }
    public string Diet { get; private set; }

    protected Animal(string name, int age, string habitat, string diet) {
      Name = name;
      Age = age;
      Habitat = habitat;
      Diet = diet;
    }

    public virtual string GetInfo() {
      return $"Name: {Name}, Age: {Age}, Habitat: {Habitat}, Diet: {Diet}";
    }
  }
}