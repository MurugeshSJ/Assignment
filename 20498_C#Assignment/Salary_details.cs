using System;

public class Program
{
    public static void Main()
    {
        Double Basic_Salary, DA, HRA, Gross_Salary;
        
        Console.Write("Enter Basic Salary : ");
        Basic_Salary = Convert.ToInt32(Console.ReadLine());
        
        DA = (Basic_Salary * 30) / 100;
        HRA = (Basic_Salary * 15) / 100;
        Gross_Salary = Basic_Salary + DA + HRA;
        
        Console.Write("\n\nDA is 30 % of Basic Salary : " + DA);
        Console.Write("\nHRA is 15 % of Basic Salary : " + HRA);
        Console.Write("\nGS is : " + Gross_Salary);
    }
}