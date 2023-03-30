namespace BrewCode.AddressTools.Models;

public record CivicAddress
{
    public string[] Address { get; init; }
    public bool Validated = false; // TODO add validator APIs i.e. google maps/USPS
    public string City { get; init; }
    public State State { get; init; }
    public int Zip5 { get; init; }
    public int Zip4 { get; init; }

    public string PostalCode => Zip4 == 0 ? string.Format("{0:00000}", Zip5) : string.Format("{0:00000}-{1:0000}", Zip5, Zip4);

    public CivicAddress(string address1, string address2, string city, string state, int zip, int zip4 = 0)
        : this(new string[] { address1, address2 }, city, state, zip, zip4) { }

    public CivicAddress(string address1, string address2, string city, State state, int zip, int zip4 = 0)
        : this(new string[] {address1, address2}, city, state, zip, zip4) { }
    public CivicAddress(string[] addressLines, string city, string state, int zip, int zip4 = 0)
    {
        State? s = StateFromString(state);
        if(s is null)
        {
            throw new ArgumentOutOfRangeException("Unable to locate State {state}", "state");
        }
        State = s.Value;
        Address = addressLines;
        City = city;
        Zip5 = zip;
        Zip4 = zip4;
    }

    public CivicAddress(string[] addressLines, string city, State state, int zip, int zip4)
    {
        Address = addressLines;
        City = city;
        State = state;
        Zip5 = zip;
        Zip4 = zip4;
    }

    private State? StateFromString(string state)
    {
        if(state.Length == 2)
        {
            return States.FromAbbreviation(state);
        }
        return States.FromName(state);
    }
}