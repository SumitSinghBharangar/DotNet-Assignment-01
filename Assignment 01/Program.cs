using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A1q1 ques01 = new A1q1();
            //ques01.func01();
            //A1q2 ques02 = new A1q2();
            //A1q3 obj = new A1q3();
            //obj.checkBalance();
            //obj.deposit(8000);
            //obj.withdraw(18000);
            //obj.checkBalance();
            A1q4 ques04 = new A1q4();
            ques04.func04();
        }
    }
    class A1q1
    {
        public void func01()
        {
            //Question 01:  Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices.
            //Include a 10% discount if the total price exceeds Rs. 3000.

            double[] shopcart = { 1000, 2800, 3000, 1980, 1235 };
            double totalsum = 0;
            for (int i = 0; i < shopcart.Length; i++)
            {
                totalsum += shopcart[i];
            }
            if (totalsum > 3000)
            {
                totalsum = (totalsum * 90) / 100;
            }
            Console.WriteLine("Your final sum is : " + totalsum.ToString());
        }
    }
    class A1q2
    {
        public void func02()
        {
            //Question: Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit.
            //If the input temperature is below 0°C, display a warning message about freezing temperatures.
            Console.WriteLine("Enter the temperature in Celsius : ");
            double temp = double.Parse(Console.ReadLine());
            double F = ((temp * 9) / 5) + 32;
            Console.WriteLine("Temperature in fahrenheit is : " + F.ToString());
        }
    }
    class A1q3
    {
        //Question: Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money,
        //and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal.
        double balance = 5000;
        public void checkBalance()
        {
            Console.WriteLine("Your current balance is : " + balance.ToString());
        }
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("After depositing " + amount.ToString() + " Your New balance is : " + balance.ToString());
        }
        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient amount ");
                return;
            }
            balance -= amount;
            Console.WriteLine("After withdrawal of " + amount.ToString() + " Your new balance is : " + balance.ToString());
        }
    }
    class A1q4
    {
        public void func04()
        {
            double[] marks = new double[5];
            double totalMarks = 0;
            Console.WriteLine("Enter the marks of five subjects ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter the marks of subject " + (i + 1) + " : ");
                marks[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < marks.Length; i++)
            {
                totalMarks += marks[i];
            }
            double average = totalMarks / 5;
            if (average > 90) Console.WriteLine("Your grade is : A");
            else if (average > 80) Console.WriteLine("Your grade is : B");
            else if (average > 70) Console.WriteLine("Your grade is : C");
            else if (average < 60) Console.WriteLine("Your grade is : D");
            else
            {
                Console.WriteLine("Your grade is : F");
            }
        }
    }
    class A1q5
    {
        //Question: Develop a C# application that asks the user to enter a password. The password should be validated based on the
        //following criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter,
        //and one number. Display appropriate messages based on the validation result.
        public void checkPassword()
        {
            Console.Write("Enter the password : ");
            string pass = Console.ReadLine();
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            if(pass.Length > 7)
            {
                foreach(char c in pass)
                {
                    if(char.IsDigit(c))
                        isDigit = true;
                    else if(char.IsLower(c))
                        isLower = true;
                    else if(char.IsUpper(c))
                        isUpper = true;
                }
                if (isUpper && isLower && isDigit)
                    Console.WriteLine("password is valid");
                return;
            }
            Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number like qRi4n9gL");
        }

    }
    class A1q6
    {

    }
}
