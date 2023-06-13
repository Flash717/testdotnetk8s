namespace TestGrpc.Model;

public class Car
{
    public Car(string _make, string _model)
    {
        this.Make = _make;
        this.Model = _model;
    }

    public string? Make { get; set; }

    public string? Model { get; set; }
}

public static class CarList
{
    public static List<Car> Cars = new List<Car>() {
        new Car("Audi", "A4"),
        new Car("BMW", "330i"),
        new Car("Chrysler", "300"),
        new Car("Dodge", "Challenger"),
        new Car("Ford", "Mustang"),
        new Car("GMC", "Yukon"),
        new Car("Honda", "Odyssey"),
        new Car("Porsche", "Carrera")
    };

}