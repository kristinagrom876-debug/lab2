namespace ZooApp {
  class Mammal : Animal {
    public bool HasFur { get; private set; }

    public Mammal(string name, int age, string habitat, string diet, bool hasFur)
        : base(name, age, habitat, diet) {
      HasFur = hasFur;
    }
    public override string GetInfo() {
      return base.GetInfo() + $", Type: Mammal, Fur: {(HasFur ? "yes" : "no")}";
    }
  }
}