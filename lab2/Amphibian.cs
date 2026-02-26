namespace ZooApp {
  class Amphibian : Animal {
    public string skinMoisture { get; private set; }

    public Amphibian(string name, int age, string habitat, string diet, string moisture)
        : base(name, age, habitat, diet) {
      skinMoisture = moisture;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Amphibian, Skin: {skinMoisture}";
    }
  }
}