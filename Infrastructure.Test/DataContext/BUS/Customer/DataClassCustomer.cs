using System.Collections;

namespace Infrastructure.Test.DataContext.BUS.Customer
{
    public class DataClassCustomer : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1000, true };
            yield return new object[] { 2000, false };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
