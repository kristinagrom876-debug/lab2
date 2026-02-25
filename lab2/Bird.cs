namespace ZooApp {
  class Bird : Animal {
    public double WingSpan { get; private set; }

    public Bird(string name, int age, string habitat, string diet, double wingSpan)
        : base(name, age, habitat, diet) {
      WingSpan = wingSpan;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Bird, Wingspan: {WingSpan} m";
    }
  }
}