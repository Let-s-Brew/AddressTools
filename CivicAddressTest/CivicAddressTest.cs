namespace BrewCode.CivicAddressTest
{
    public class CivicAddressTest
    {
        [Fact]
        public void TestStates()
        {
            foreach(var state in States.StateList)
            {
                Assert.Contains(state.LongName.ToUpper(),States.StateNames);
                Assert.NotNull(States.FromName(state.LongName));

                Assert.Contains(state.Abbrivation.ToUpper(), States.StateAbbreviations);
                Assert.NotNull(States.FromAbbreviation(state.Abbrivation));
            }

        }
    }
}