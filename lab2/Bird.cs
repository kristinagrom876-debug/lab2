namespace ZooApp {
  class Bird : Animal {
    public double wingSpan { get; private set; }

    public Bird(string name, int age, string habitat, string diet, double span)
        : base(name, age, habitat, diet) {
      wingSpan = span;
    }

    public override string GetInfo() {
      return base.GetInfo() + $", Type: Bird, Wingspan: {wingSpan} m";
    }
  }
}