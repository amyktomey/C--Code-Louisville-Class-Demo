// See https://aka.ms/new-console-template for more information

namespace BethanysPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingValueParameters();
            //UsingRefParameters();
            //UsingOutParameters();

            //int monthlyWage = 1234;
            //int months = 12;
            //int bonus = 1000;

            //int yearlyWage = CalculateYearlyWage(monthlyWage, months, bonus);

            //Console.WriteLine($"Yearly wage (from main): {yearlyWage}");


            // double monthlyWageDouble = 1500.0;
            // double monthsDouble = 12;
            // double bonusDouble = 1000;
            // double yearlyWageWithBonusDouble = CalculateYearlyWage(monthlyWageDouble, monthsDouble, bonusDouble);

            Console.ReadLine();
        }

        public static void UsingValueParameters()
        {
            int monthlyWage1 = 1234;
            int monthlyWage2 = 2000;
            int months1 = 12;
            int months2 = 8;
            int bonus = 300;

            int yearlyWageForEmployee1 = CalculateYearlyWage(monthlyWage1, months1, bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany):{yearlyWageForEmployee1}");

            int yearlyWageForEmployee2 = CalculateYearlyWage(monthlyWage2, months2, bonus);
            Console.WriteLine($"Yearly wage for employee 2 (John):{yearlyWageForEmployee2}");
        }

        //public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        //{
        //    //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        //    if (numberOfMonthsWorked == 12)//let's add a bonus month
        //        return monthlyWage * (numberOfMonthsWorked + 1);

        //    return monthlyWage * numberOfMonthsWorked;
        //}

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000)
                bonus *= 2;
        
        Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        Console.WriteLine($"The employee got a bonus of {bonus}");
        return monthlyWage * (numberOfMonthsWorked + bonus);
        }

        //public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        //{
        //    Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
        //    return monthlyWage * (numberOfMonthsWorked + bonus);
        //}
    }
}
//private static void UsingRefParameters();

//public  static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, ref int bonus);

//private static void UsingOutParameters()
//{
//    int monthlyWage1 = 1234;
//    int months1 = 12;
//    int bonus;// notice: no initial value has been set
//
//    int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
//    Console.WriteLine($"Yearly wage for employee 1 (Bethany):{yearlyWageForEmployee1}");
//    Console.WriteLine($"Employee1 got a bonus of {bonus}");
//}
//public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
//        {
//            bonus = new Random().Next(1000);//C# code to generate a random number smaller than 1000
//            if (bonus < 500)
//            {
//                bonus *= 2;
//                Console.WriteLine("Bonus is doubled!! Yay!!");
//            }

//            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
//            return monthlyWage * numberOfMonthsWorked + bonus;
//        }

    
//    }








// from earlier class demos same module
//Console.WriteLine("Enter the monthly wage: ");
//string wage = Console.ReadLine();

//int wageValue = int.Parse(wage);

//int wageValue;
//if (int.TryParse(wage, out wageValue))
//    Console.WriteLine("Parsing success: " + wageValue);
//else
//    Console.WriteLine("Parsing failed");


//var monthlyWage = 1234;
//int months = 12, bonus = 1000;

//var isActive = true;
//var rating = 99.25;

//double ratePerHour = 12.34;
//int numberOfHoursWorked = 165;

//long veryLongMonth = numberOfHoursWorked;
//double d = 12345678.9;
//int x = (int)d;

//long intVeryLongMonth = (int)veryLongMonth;

//double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

//Console.WriteLine(currentMonthWage);

//ratePerHour += 3; //ratePerHour = RatePerHour +3;

//if (currentMonthWage > 2000)
//{
//    Console.WriteLine("Top Paid Employee!");
//}

//int numberOfEmployees = 15;
//numberOfEmployees--;

//int intMaxValue = int.MaxValue;
//int intMinValue = Int32.MinValue;

//char userSelection = 'a';
//char upperVersion = char.ToUpper(userSelection);
//bool isDigit = char.IsDigit(userSelection);
//bool isLetter = char.IsLetter(userSelection);

//string hireDateString = "12/12/2020";
//DateTime hireDate = DateTime.Parse(hireDateString);
//Console.WriteLine("Parsed date: " + hireDate);

////var cultureInfo = new CultureInfo("n1-BE");// error @2:47 in module 4 Demo: Parsing strings
////string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium
////var birthDate = DateTime.Parse(birthDateString, cultureInfo);
////Console.WriteLine("Birth date: " + birthDate);


//DateTime exitDate = new DateTime(2021, 12, 31);

////DateTime invalidDate = new DateTime(2021, 15, 11);

//DateTime startDate = hireDate.AddDays(15);

//Console.WriteLine(startDate);

//DateTime currentDate = DateTime.Now;
//bool areWeInDst = currentDate.IsDaylightSavingTime();

//DateTime startHour = DateTime.Now;
//TimeSpan workTime = new TimeSpan(8, 35, 0);
//DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongDateString());
//Console.WriteLine(endHour.ToShortTimeString());



//string firstName = "Bethany";
//string lastName = "Smith";

//string fullName = firstName + " " + lastName;
//string employeeIdentification = string.Concat(firstName, lastName);

//string displayName = $"Welcome! \n{firstName}\t{lastName}";

//Console.WriteLine(displayName);

//string marketingTagLine = "Baking the \"best Pies\" ever";

//string empId = firstName.ToLower() + " " + lastName.Trim().ToLower();

//int length = empId.Length;

//if (fullName.Contains("beth") || fullName.Contains("Beth"))
//{
//    Console.WriteLine("It's Bethany!");
//}

//string subString = fullName.Substring(1, 3);
//Console.WriteLine("Characters 2 to 4 of fullname are " + subString);

//string nameUsingInterpolaiton = $"{firstName}-{lastName}";

//string greeting = $"Hello, {firstName.ToLower()}";

//Console.WriteLine(greeting);

//string name = "Bethany";
//string anotherName = name;

//Console.WriteLine("Name: " + name);
//Console.WriteLine("Another name: " + anotherName);

//string lowerCaseName = name.ToLower();

//string indexes = string.Empty;
//for (int i = 0; i < 2500; i++)
//{
//    indexes += i.ToString();
//}


//System.Text.StringBuilder builder = new StringBuilder();


//builder.Append("Last Name: ");
//builder.AppendLine(lastName);
//builder.Append("First Name: ");
//builder.Append(firstName);
//string result = builder.ToString(); 

//Console.WriteLine(result);  

//Console.ReadLine();