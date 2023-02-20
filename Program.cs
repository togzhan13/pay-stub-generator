using System;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        //Global variables for Health Insurance, Tax Withhold Rate, and Retirement Contribution Rate
        static double healthInsuranceRate = 0.06;
        static double taxWithholdRate = 0.15;
        static double retirementContributionRate = 0.12;

        static void Main(string[] args)
        {
            //Get information from user
            Console.WriteLine("Enter employee's First Name: ");
            string firstName = ReadLine();
            Console.WriteLine("Enter employee's Last Name: ");
            string lastName = ReadLine();
            Console.WriteLine("Enter {0} {1}'s biweekly working hours: ", firstName, lastName);
            double biWeeklyWorkingHours = Convert.ToInt32(ReadLine());
            Console.WriteLine("Enter {0} {1}'s hourly pay rate: ", firstName, lastName);
            double payRate = Convert.ToDouble(ReadLine());

            //Calculate pay stub information
            double biWeeklyGrossPay = biWeeklyWorkingHours * payRate;
            double healthInsuranceFee = biWeeklyGrossPay * (healthInsuranceRate);
            double taxWithholdAmount = biWeeklyGrossPay * (taxWithholdRate);
            double retirementContribution = biWeeklyGrossPay * (retirementContributionRate);
            double biWeeklyNetPay = biWeeklyGrossPay - (healthInsuranceFee + taxWithholdAmount + retirementContribution);

            //Display pay stub information
            WriteLine("Pay Stub:");
            WriteLine("********************************************************************************");
            WriteLine("*{0,42}{1,37}", "Pay Stub", "*");
            WriteLine("********************************************************************************");
            WriteLine("*{0,26}: {1,-25}*{2,25}", "Employee Name", firstName + " " + lastName, "*");
            WriteLine("*{0,26}:{1,27}{2,24}*", "Bi-weekly Working Hours", "*", biWeeklyWorkingHours);
            WriteLine("*{0,26}:{1,27}{2,18}\t{3:C}*", "Pay Rate", "*", "X ", payRate);
            WriteLine("********************************************************************************");
            WriteLine("*{0,49}:{1,28:C}*", "Gross Pay", biWeeklyGrossPay);
            WriteLine("*{0,26}:{1,27}{2,17}\t{3:C}*", "Health Insurance", "*", "- ", healthInsuranceFee);
            WriteLine("*{0,26}:{1,27}{2,17}\t{3:C}*", "Tax Withhold", "*", "- ", taxWithholdAmount);
            WriteLine("*{0,26}:{1,27}{2,17}\t{3:C}*", "Retirement Contribution", "*", "- ", retirementContribution);
            WriteLine("********************************************************************************");
            WriteLine("*{0,49}:{1,28:C}*", "Net Pay", biWeeklyNetPay);
            WriteLine("********************************************************************************");
            Console.ReadLine();
        }
    }
}
