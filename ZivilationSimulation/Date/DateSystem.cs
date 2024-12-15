namespace ZivilationSimolation.Date;

public class DateSystem
{
    private static int Year { get; set; }
    private static Month Month { get; set; }
    private static int Day { get; set; }
    public static String Date = "{Day}.{Month}.{Year}";
    
    //Just needs one trigger to start date system
    public static void StartDateSystem()
    {
        //initializing variables
        Year = 1;
        Month = Month.January;
        
        //While for Month Management
        while (Program.IsRunning)
        {
            if (Month == Month.January && Day > 31)
            {
                Day = 1;
                Month = Month.February;
            }
            else if (Month == Month.February)
            {
                //Check if leapyear
                int febDays = IsLeapYear(Year) ? 29 : 28;
                if (Day > febDays)
                {
                    Day = 1;
                    Month = Month.March;
                }
            }
            else if (Month == Month.March && Day > 31)
            {
                Day = 1;
                Month = Month.April;
            }
            else if (Month == Month.April && Day > 30)
            {
                Day = 1;
                Month = Month.May;
            }
            else if (Month == Month.May && Day > 31)
            {
                Day = 1;
                Month = Month.June;
            }
            else if (Month == Month.June && Day > 30)
            {
                Day = 1;
                Month = Month.July;
            }
            else if (Month == Month.July && Day > 31)
            {
                Day = 1;
                Month = Month.August;
            }
            else if (Month == Month.August && Day > 31)
            {
                Day = 1;
                Month = Month.September;
            }
            else if (Month == Month.September && Day > 30)
            {
                Day = 1;
                Month = Month.October;
            }
            else if (Month == Month.October && Day > 31)
            {
                Day = 1;
                Month = Month.November;
            }
            else if (Month == Month.November && Day > 30)
            {
                Day = 1;
                Month = Month.December;
            }
            else if (Month == Month.December && Day > 31)
            {
                Day = 1;
                Month = Month.January;
                Year++; // Increment year when rolling over to January
            }  
        }
    }
    
    //Skip day method
    public static void SkipDay()
    {
        Day++;
        Date = "{Day}.{Month}.{Year}";
    }
    
    //Complex system for LeapYear check
    public static bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
        {
            return false;
        }
        else if (year % 100 != 0)
        {
            return true;
        }
        else if (year % 400 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}