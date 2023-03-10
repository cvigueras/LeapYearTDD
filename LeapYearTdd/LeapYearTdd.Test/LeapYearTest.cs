using LeapYearTdd.Console;

namespace LeapYearTdd.Test
{
    public class LeapYearTest
    {
        [Test]
        public void test_if_year_is_leap_year_if_is_divisible_by_400()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(400);
            Assert.IsTrue(result);
        }

        [Test]
        public void test_if_year_is_not_leap_year_if_is_divisible_by_100_but_not_divisible_by_400()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(100);
            Assert.IsFalse(result);
        }

        [Test]
        public void test_if_year_is_leap_year_if_is_divisible_by_4_but_not_divisible_by_100()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(4);
            Assert.IsTrue(result);
        }

        [Test]
        public void test_if_year_is_not_leap_year_if_is_not_divisible_by_4()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(5);
            Assert.IsFalse(result);
        }

        [Test]
        public void test_if_year_is_not_leap_year_if_value_is_zero()
        {
            var leapYear = new LeapYear();
            var result = leapYear.IsLeapYear(0);
            Assert.IsFalse(result);
        }
    }
}