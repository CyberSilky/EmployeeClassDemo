using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;


namespace EmployeeClassDemo
{
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            BonusEmployee b1 = new BonusEmployee();

            try
            {
                e.Id = 12;
                e.LastName = "Smith";
                Console.WriteLine(e.Greeting("Becky"));

                //setting salary 
                e.Salary = 2500000;

                Console.WriteLine(" Congratulations your salary is {0}", e.Salary.ToString("C"));
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine("An error occured - looks like a bad salary value", ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("An error occured - caught by invalid op exception", ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occured- caught by parent", ex.Message);
            }
            finally
            {
                Console.WriteLine($"This runs all the time");
            }
        }
    }
}
