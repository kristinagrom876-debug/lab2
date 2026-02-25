namespace ZooApp {
  class Fish : Animal {
    public string WaterType { get; private set; }

    public Fish(string name, int age, string habitat, string diet, string waterType)
        : base(name, age, habitat, diet) {
      WaterType = waterType;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Fish, Water: {WaterType}";
    }
  }
}