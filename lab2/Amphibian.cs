namespace ZooApp {
  class Amphibian : Animal {
    public string SkinMoisture { get; private set; }

    public Amphibian(string name, int age, string habitat, string diet, string skinMoisture)
        : base(name, age, habitat, diet) {
      SkinMoisture = skinMoisture;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Amphibian, Skin: {SkinMoisture}";
    }
  }
}