namespace RecordInheritance
{
    public record PositionalCar(string Make, string Model, string Color);
    public record PositionalMiniVan (string Make, string Model, string Color, int seating) : PositionalCar(Make, Model, Color);
}

