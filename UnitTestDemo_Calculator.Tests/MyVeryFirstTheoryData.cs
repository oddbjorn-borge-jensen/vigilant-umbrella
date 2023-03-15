using System.Collections;

namespace UnitTestDemo_Calculator.Tests
{
    public class MyVeryFirstTheoryData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 1, 2 };
            yield return new object[] { 2, 0, 2 };
            yield return new object[] { 7, -1, 6 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
