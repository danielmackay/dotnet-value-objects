namespace ValueObjects.Option4;

public record Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }

    public Address(string street, string city, string state)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(street);
        ArgumentException.ThrowIfNullOrWhiteSpace(city);
        ArgumentException.ThrowIfNullOrWhiteSpace(state);

        Street = street;
        City = city;
        State = state;
    }

    public bool IsInState(string state) => State == state;
}
