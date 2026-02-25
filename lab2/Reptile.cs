namespace ZooApp {
  class Reptile : Animal {
    public bool IsVenomous { get; private set; }

    public Reptile(string name, int age, string habitat, string diet, bool isVenomous)
        : base(name, age, habitat, diet) {
      IsVenomous = isVenomous;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Reptile, Venomous: {(IsVenomous ? "yes" : "no")}";
    }
  }
}