using System;
using System.Collections.Generic;
using static test.Delegates;
using static test.Events;

namespace test
{
    internal class Program
    {
        static void DelegateExample_Showcase()
        {

            List<Employee> employees = FillListWithEmployees(); //40 emps list

            Console.WriteLine("Count = " + CountEmployees(employees, AllEmployees));           //Count = 40
            Console.WriteLine("Count = " + CountEmployees(employees, IsSalaryMoreThan5000));   //Count = 28
            Console.WriteLine("Count = " + CountEmployees(employees, IsSalaryLessThan2000));   //Count = 0
            Console.WriteLine("Count = " + CountEmployees(employees, IsNameStartWithR));       //Count = 2
            Console.WriteLine("Count = " + CountEmployees(employees, IsBirthDateAfter2000));   //Count = 7

            //anonymous function that checks for department
            Console.WriteLine("Count = " + CountEmployees(employees, delegate (Employee employee) { return employee.Department == "IT"; }));    //Count = 5 


            //lambda expression that checks for department
            Console.WriteLine("Count = " + CountEmployees(employees, (Employee employee) => { return employee.Department == "IT"; }));    //Count = 5 
            //we can make lambda expression less code like this
            Console.WriteLine("Count = " + CountEmployees(employees, employee => employee.Department == "IT"));    //Count = 5 

        }

        static void EventsExample_Showcase()
        {
            List<Stock> StocksList = FillListWithStocks(); //20 sample stocks list

            StocksList[0].OnPriceChange += Program_OnPriceChange; //subscribe to the event using += , (-= for unsubscribe)
            //now the Program is a Subscriber to the event in Stock class

            StocksList[0].PrintInfo();

            StocksList[0].ChangePriceBy(0.15);
            StocksList[0].PrintInfo(); //price up, green
            
            StocksList[0].ChangePriceBy(-0.45); //price down, red
            StocksList[0].PrintInfo();

            void Program_OnPriceChange(Stock stock, double oldPrice)
            {
                if (stock.Price >= oldPrice)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (stock.Price <= oldPrice)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.White;

            }

        }

        static void Main(string[] args)
        {
            //DelegateExample_Showcase();

            //EventsExample_Showcase();

            Console.ReadLine();
        }

        
    }
}
