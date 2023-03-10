namespace LeapYearTdd.Test
{
    public class LeapYearTest
    {
        [Test]
        public void test_is_year_is_leap_year_if_is_divisible_by_400()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(400);
            Assert.IsTrue(result);
        }
    }

    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            return true;
        }
    }
}
