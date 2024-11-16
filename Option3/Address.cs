namespace ValueObjects.Option3;

public record Address
{
    public string Street { get; init; }
    public string City { get; init; }
    public string State { get; init; }

    public Address(string street, string city, string state)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(street);
        ArgumentException.ThrowIfNullOrWhiteSpace(city);
        ArgumentException.ThrowIfNullOrWhiteSpace(state);

        Street = street;
        City = city;
        State = state;
    }
}
