namespace Infrastructure.Test.DataContext.BUS.Customer
{
    public static class DataMemberCustomer
    {

        #region Property Type
        public static TheoryData<int, bool> CustomerPropertyData
        {
            get
            {
                return new TheoryData<int, bool>
                {
                    { 1000,true },
                    { 2000, false },
                };
            }
        }
        //  Usage
        //[MemberData(nameof(CustomerPropertyData))]
        #endregion
       
        #region Method Type 
        public static IEnumerable<object[]> CustomerMethodData()
        {
            var result = new List<object[]>();
            result.Add(new object[] { 2300, true });
            result.Add(new object[] { 1400, false });
            return result;
        }
        //  Usage
        //  [MemberData(nameof(CustomerPropertyData))]
        public static IEnumerable<object[]> CustomerMethodData(int count)
        {
            var result = new List<object[]>();
            result.Add(new object[] { 2300, true });
            result.Add(new object[] { 1400, false });
            return result;
        }
        //  Usage
        //  [MemberData(nameof(CustomerMethodData),3)]
        #endregion

        #region Yield
        public static IEnumerable<object[]> CustomerMethodYieldData()
        {
            yield return new object[] { 1000, true };
            yield return new object[] { 2000, false };
        }
        #endregion
    }
}
