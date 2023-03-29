namespace BrewCode.AddressTools.Models;

/// <summary>
/// Represents a State portion of an Address. By default, <c>ToString()</c> returns the
/// <c>LongName</c> of the State. To get the 2 letter abbreviation use <c>State.Abbreviation</c>
/// </summary>
/// <seealso cref="States"/>
public record struct State
{
    public string LongName { get; init; }
    public string Abbrivation { get; init; }

    internal State(string name, string abbrivation)
    {
        LongName = name;
        Abbrivation = abbrivation;
    }

    public override string ToString()
    {
        return LongName;
    }
}

public static class States
{
    public static State Alabama = new State("Alabama", "AL");
    public static State Alaska = new State("Alaska", "AK");
    public static State Arizona = new State("Arizona", "AZ");
    public static State Arkansas = new State("Arkansas", "AK");
    public static State California = new State("California", "CA");
    public static State Colorado = new State("Colorado", "CO");
    public static State Connecticut = new State("Connecticut", "CT");
    public static State Delaware = new State("Delaware", "DE");
    public static State DistrictOfColumbia = new State("District of Columbia", "DC");
    public static State Florida = new State("Florida", "FL");
    public static State Georgia = new State("Georgia", "GA");
    public static State Hawaii = new State("Hawaii", "HI");
    public static State Idaho = new State("Idaho", "ID");
    public static State Illinois = new State("Illinois", "IL");
    public static State Indiana = new State("Indiana", "IN");
    public static State Iowa = new State("Iowa", "IA");
    public static State Kansas = new State("Kansas", "KS");
    public static State Kentucky = new State("Kentucky", "KY");
    public static State Louisiana = new State("Louisiana", "LA");
    public static State Maine = new State("Maine", "ME");
    public static State Maryland = new State("Maryland", "MD");
    public static State Massachusetts = new State("Massachusetts", "MA");
    public static State Michigan = new State("Michigan", "MI");
    public static State Minnesota = new State("Minnesota", "MN");
    public static State Mississippi = new State("Mississippi", "MS");
    public static State Missouri = new State("Missouri", "MO");
    public static State Montana = new State("Montana", "MT");
    public static State Nebraska = new State("Nebraska", "NE");
    public static State Nevada = new State("Nevada", "NV");
    public static State NewHampshire = new State("New Hampshire", "NH");
    public static State NewJersey = new State("New Jersey", "NJ");
    public static State NewMexico = new State("New Mexico", "NM");
    public static State NewYork = new State("New York", "NY");
    public static State NorthCarolina = new State("North Carolina", "NC");
    public static State NorthDakota = new State("North Dakota", "ND");
    public static State Ohio = new State("Ohio", "OH");
    public static State Oklahoma = new State("Oklahoma", "OK");
    public static State Oregon = new State("Oregon", "OR");
    public static State Pennsylvania = new State("Pennsylvania", "PA");
    public static State RhodeIsland = new State("Rhode Island", "RI");
    public static State SouthCarolina = new State("South Carolina", "SC");
    public static State SouthDakota = new State("South Dakota", "SD");
    public static State Tennessee = new State("Tennessee", "TN");
    public static State Texas = new State("Texas", "TX");
    public static State Utah = new State("Utah", "UT");
    public static State Vermont = new State("Vermont", "VT");
    public static State Virginia = new State("Virginia", "VA");
    public static State Washington = new State("Washington", "WA");
    public static State WestVirgina = new State("West Virginia", "WV");
    public static State Wisconsin = new State("Wisconsin", "WI");
    public static State Wyoming = new State("Wyoming", "WY");

    private static readonly List<State> _states = new List<State>()
    {
        Alabama, Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, DistrictOfColumbia, Florida, Georgia, Hawaii,
        Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland, Massachusetts, Michigan, Minnesota, Mississippi,
        Missouri, Montana, Nebraska, Nevada, NewHampshire, NewJersey, NewMexico, NewYork, NorthCarolina, NorthDakota, Ohio, Oklahoma,
        Oregon, Pennsylvania, RhodeIsland, SouthCarolina, SouthDakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, WestVirgina,
        Wisconsin, Wyoming
    };
    private static Dictionary<string, State> _stateAbbrDict = new Dictionary<string, State>();
    private static Dictionary<string, State> _stateNameDict = new Dictionary<string, State>();

    static States() {
        foreach(var state in _states)
        {
            _stateAbbrDict.Add(state.Abbrivation, state);
            _stateNameDict.Add(state.LongName.ToUpper(), state);
        }
    }

    public static State? FromAbbreviation(string abbreviation)
    {
        if(abbreviation.Length != 2)
        {
            throw new ArgumentException("State abbreviation must be 2 characters", "abbreviation");
        }
        abbreviation = abbreviation.ToUpper();
        return _stateAbbrDict.ContainsKey(abbreviation) ? _stateAbbrDict[abbreviation] : null;
    }

    public static State? FromName(string name)
    {
        name = name.ToUpper();
        return _stateNameDict.ContainsKey(name) ? _stateNameDict[name] : null;
    }
}
