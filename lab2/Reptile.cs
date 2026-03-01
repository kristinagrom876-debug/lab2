namespace ZooApp {
  class Reptile : Animal {
    public bool isVenomous { get; private set; }

    public Reptile(string name, int age, string habitat, string diet, bool venomous)
        : base(name, age, habitat, diet) {
      isVenomous = venomous;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Reptile, Venomous: {(isVenomous ? "yes" : "no")}";
    }
  }
}