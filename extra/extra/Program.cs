using System;
using System.Globalization;
class Concatenates
{
    static void Part1()
    {
        string firstName = " nguyen";
        string lastName = "Thang";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName);
    }

    static void Part2()
    {
        Console.WriteLine("Please enter your user name !!");
        string userName= Console.ReadLine();
        Console.WriteLine(userName);
    }
    static void Part3()
    {
        string clan = "Clan: ";
        string clanName = "Hyperx";
        string clanState = " Top 1 ";
        string result = clan + clanName + clanState;
        Console.WriteLine(result);
    }
    static void Part4()
    {
        string name = Console.ReadLine( );
        int ID = int.Parse(Console.ReadLine());
        string user = name + ID;
        Console.WriteLine(user);

    }
    //public static void Main()
    //{
    //    //Part1();
    //    //Part2();
    //    //Part3();
    //    //Part4();
    //}
    
    
}

///CONVERSION///

class Conversion
{
    static void Part1()
    {
        float height = float.Parse(Console.ReadLine());
        float weight = float.Parse(Console.ReadLine());

        float BMI = weight / (height * height);
        Console.WriteLine("Your BMI is "+BMI);

        if (BMI < 18.5)
        {
            Console.WriteLine("UnderWeight");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
    static void Part2()
    {
        float heightInFeet = float.Parse(Console.ReadLine());
        float heightInInches = float.Parse(Console.ReadLine());
        float weight = float.Parse(Console.ReadLine());
        float totalHeight = heightInFeet * 12 + heightInInches;
        float BMI = (weight * 703) / (totalHeight * totalHeight);
        Console.WriteLine("Your BMI is " + BMI);
        if (BMI < 18.5)
        {
            Console.WriteLine("UnderWeight");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");

        }
    }
    static void Part4()
    {
        double playerHealth = double.Parse(Console.ReadLine());
        Console.WriteLine(playerHealth);
        int percentageHealth = Convert.ToInt32(playerHealth*100); //= (int)(playerHealth*100);
        Console.WriteLine($"Player's Health in percentage is {percentageHealth}%");

    }
    static void Part3()
    {
        int score = int.Parse(Console.ReadLine());
        double scoreInDecimal = (double)(score);
        Console.WriteLine(score);
        Console.WriteLine($"Player's Score with one decimal place: {scoreInDecimal:F1}");
    }
    static void Part5()
    {
        double playerCoin = double.Parse(Console.ReadLine());
        int roundedCoin = (int)playerCoin; //Only rounded down
        int coin = Convert.ToInt32(playerCoin); // round by math rules
        Console.WriteLine(roundedCoin);
        Console.WriteLine(coin);
    }

    static void Part6()
    {
        bool playerProgress = Convert.ToBoolean(Console.ReadLine());

        string progressStatus = GetProgressStatus(playerProgress);
        Console.WriteLine(progressStatus);
        string GetProgressStatus(bool status)
        {
            if (status)
            {
                return "Completed !!";
            }
            else
            {
                return "Incompleted !!";
            }

        }
    }

    //public static void Main()
    //{
    //    Part1();
    //    Part2();
    //    Part3();
    //    Part4();
    //    Part5();
    //    Part6();
    //}
}

                    ////// DateTime//////
class DatandTime
{
    private int year;
    private int month;
    private int day;



    public static DateTime Now { get; private set; }

    static void Part1()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"{day}/{month}/{year}");
        int numberOfDays = int.Parse(Console.ReadLine());
        Console.WriteLine("Number of days: "+numberOfDays);
        int day2 = day + numberOfDays;
        if(day2 > 30)
        {
            day2 -= 30;
            month += 1;
        }
        if (day2 < 1)
        {
            day2 += 30;
            month -= 1;
        }
        if(month > 12)
        {
            month -= 12;
            year += 1;
        }
        if(month < 1)
        {
            month += 12;
            year -= 1;
        }

       Console.WriteLine($"{day2}/{month}/{year}");
        
    }
    static void Part2()
    {
        Console.WriteLine("Enter your date of birth (dd/mm/yyyy):");
        string inputDate = Console.ReadLine();


        DateTime dateOfBirth = DateTime.ParseExact(inputDate, "dd/MM/yyyy", null);
        DateTime today = DateTime.Now;
        int years = today.Year - dateOfBirth.Year;
        int months = today.Month - dateOfBirth.Month;
        int days = today.Day - dateOfBirth.Day;
        if (months < 0)
        {
            years--;
            months += 12;
        }
        if (days < 0)
        {


            months += 12;
            years--;
            DateTime previousMonth = today.AddMonths(-1);

            days += DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);

        }

        Console.WriteLine($"You are {years} years, {months} months, {days} days old.");
        ;

    }


    static void Part3()

    {

        Console.WriteLine("Input First date (dd/mm/yyyy)");

        string inputFirstDate = "12/01/2024";

        DateTime firstDate = DateTime.ParseExact(inputFirstDate, "dd/MM/yyyy", null);

        string inputSecondDate = "18/02/2024";

        DateTime SecondDate = DateTime.ParseExact(inputSecondDate, "dd/MM/yyyy", null);


        TimeSpan difference = SecondDate - firstDate;


        Console.WriteLine("The defference date is: " + Math.Abs(difference.Days) + " days");


    }

  

    static void Part4()

    {

        int numberOfDays = int.Parse(Console.ReadLine());

        int years = numberOfDays / 365;

        int remainDays = numberOfDays % 365;

        int weeks = remainDays / 7;

        int days = remainDays % 7;

        Console.WriteLine("remainDays: " + remainDays);

        Console.WriteLine($"Years : {years}, Week: {weeks}, Days: {days}");


    }

    static void Part5()

    {

        int numberOfDays = int.Parse(Console.ReadLine());

        string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.WriteLine(week[numberOfDays - 1]);

    }

    static void Part6()

    {

        DateTime today = DateTime.Now;

        Console.WriteLine(today.ToString("dd/MM/yyyy"));
        

    }

   
    static void Part7()

    {

        DateTime today = DateTime.Now;

        Console.WriteLine(today.ToString("dd/MM/yyyy HH:mm:ss"));

    }

    //public static void Main()
    //{
    //    //Part1();
    //    Part2();
    //    Part3();
    //    Part4();
    //    Part5();
    //    Part6();
    //    Part7();
    //}
}

/// TRY Catch/
class TryCatch
{
    static void Part1()
    {
        try
        {
            int number1 = 10;
            int number2 = 0;
            int result = number1 / number2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: "+ex.Message);
        }

    }
    static void Part2()
    {
        try
        {
            string name = "thang";
            int convertToInt = int.Parse(name);
        }
        catch(Exception ex) 
        {
            Console.WriteLine("Error: " + ex.Message);
        }
       
    }
    static void Part3()
    {
        string filePath = "non_exist_file";
        try
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(sr);
            }
        }
        catch(FileNotFoundException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error: "+ex.Message);
        }
    }
    static void Part4()
    {
        try
        {
        int input = int.Parse(Console.ReadLine());

        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void Part5()
    {
        try
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void Main()
    {
        //Part1();
        //Part2();
        //Part3();
        //Part4();
        Part5();
    }
}