namespace ZooApp {
  class Fish : Animal {
    public string waterType { get; private set; }

    public Fish(string name, int age, string habitat, string diet, string water)
        : base(name, age, habitat, diet) {
      waterType = water;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Fish, Water: {waterType}";
    }
  }
}