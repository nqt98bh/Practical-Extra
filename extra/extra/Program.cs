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
    static void Part6()
    {
        try
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = number1 / number2;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Part7()
    {
        try
        {

            int number1 = int.Parse(Console.ReadLine());

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    static void Part8()
    {
        try
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = number1 / number2;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static void Part9()
    {
        string input = null;
        try
        {

            string uppercase = input.ToUpper();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    static void MyTelephoneDirectory()
    {
        string filePath = @"C:\Unitylearn\repos\Practical-Extra\extra\extra\PhoneDirectory.csv";
        int recordCount = 0;
        string inputName, inputPhoneNumber;
        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Name,Phone Number");
            }
        }
        do
        {
            Console.Write("Enter name (or 'Exit' to quit): ");
            inputName = Console.ReadLine();
            if (inputName.ToLower() == "exit")
                break;

            Console.Write("Enter phone number: ");
            inputPhoneNumber = Console.ReadLine();
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{inputName},{inputPhoneNumber}");
            }

            recordCount++;
        }
        while (true);
        Console.WriteLine($"Number of records appended: {recordCount}");

    }
    static void LibraryLoan()
    {
        string inputFile = @"C:\Unitylearn\repos\Practical-Extra\extra\extra\loaninfo.csv";
        string outputFile = @"C:\Unitylearn\repos\Practical-Extra\extra\extra\overdueinfo.csv";
        try
        {
            string[] lines = File.ReadAllLines(inputFile);
            using(StreamWriter sw = new StreamWriter(outputFile))
            {
                Console.WriteLine("{0,-10} {1,-12} {2,-14} {3,-14} {4,-12} {5,-13} {6,-8}", "Book ID", "Borrower ID", "Date Borrowed", "Date Returned", "Days Loaned", "Days Overdue", "Fine");
                sw.WriteLine("Book ID, Borrower ID, Days Overdue, Fine");
                for(int i = 1;  i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    string bookID = parts[0];
                    string borrowerID = parts[1];
                    DateTime dateBorrowed = DateTime.ParseExact(parts[2], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    DateTime dateReturned = DateTime.ParseExact(parts[3], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    int daysLoaned = (int)(dateReturned - dateBorrowed).TotalDays;
                    // Calculate days overdue and fine
                    int daysOverdue = Math.Max(daysLoaned - 14, 0);
                    double fine = daysOverdue * 0.5;
                    // Write data to console
                    Console.WriteLine($"{bookID,-10} {borrowerID,-12} {dateBorrowed,-14:yyyy-MM-dd} {dateReturned,-14:yyyy-MM-dd} {daysLoaned,-12} {daysOverdue,-13} ${fine,-8:F2}");
                    // Write data to output file if overdue
                    if (daysOverdue > 0)
                    {
                        sw.WriteLine($"{bookID}, {borrowerID}, {daysOverdue}, ${fine:F2}");
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    public static void Main()
    {
        //    Part1();
        //    Part2();
        //    Part3();
        //    Part4();
        //    Part5();
        //    Part6();
        //    Part7();
        //    Part8();
        //    Part9();
        //MyTelephoneDirectory();
        LibraryLoan();
    }

}

//Math//
class Math1
{
    
    static void Part5()
    {
        int a = 10;
        int b = 5;
        int c = Math.Min(a, b);
        Console.WriteLine("The minimum of 5 and 10 is " + c);
    }

    static void Part6()
    {
        int a = 15;
        int b = 8;
        int c = Math.Max(a, b);
        Console.WriteLine("The maximum of 15 and 8 is " + c);
    }
    static void Part7()
    {
        int a = 144;
        int b = (int)Math.Sqrt(a);
        Console.WriteLine("The square root of 144 is " + b);
    }
    static void Part8()
    {
        int a = Math.Abs(-5);
        Console.WriteLine("The absolute value of -5 is " + a);
    }
    static void Part9()
    {
        double a = Math.Pow(2, 5);
        Console.WriteLine("2 raised to the power of 5 is " + a);
    }
    static void Part10()
    {
        double a = Math.Round(4.6);
        Console.WriteLine("4.6 rounded to the nearest integer is " + a);
    }
    static void Part11()
    {
        double a = Math.Ceiling(3.14);
        Console.WriteLine("The smallest integer greater than or equal to 3.14 is " + a);
    }
    static void Part12()
    {
        double a = Math.Exp(2);
        Console.WriteLine("e raised to the power of 2 is " + a);
    }
    static void Part13()
    {
        double a = Math.Log(100);
        Console.WriteLine("The natural logarithm of 100 is " + a);
    }
    static void Part14()
    {
        Random random = new Random();

        int a = random.Next(1, 100);
        Console.WriteLine("A random number between 1 and 100 is " + a);
        
    }
    //public static void Main(string[] args)
    //{
    //    Part5();
    //    //Part6();
    //    //Part7();
    //    //Part8();
    //    //Part9();
    //    //Part10();
    //    //Part11();
    //    //Part12();
    //    //Part13();
    //    //Part14();
    //}
    
}