namespace ZooApp {
  class Mammal : Animal {
    public bool hasFur { get; private set; }

    public Mammal(string name, int age, string habitat, string diet, bool fur)
        : base(name, age, habitat, diet) {
      hasFur = fur;
    }
    public override string GetInfo() {
      return base.GetInfo() + $", Type: Mammal, Fur: {(hasFur ? "yes" : "no")}";
    }
  }
}