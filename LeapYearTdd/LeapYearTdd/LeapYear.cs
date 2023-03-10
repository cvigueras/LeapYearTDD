﻿namespace LeapYearTdd.Console;

public class LeapYear
{
    public bool IsLeapYear(int year)
    {
        return year != 0 && (year % 400 == 0 || year % 4 == 0 && year % 100 > 0);
    }
}