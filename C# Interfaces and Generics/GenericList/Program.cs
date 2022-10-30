using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new list object for employee objects
            List<Employee> empList = new List<Employee>(10);
            
            // Add some records to list
            empList.Add(new Employee("Jon", 50000));
            empList.Add(new Employee("Jane", 60000));
            empList.Add(new Employee("Nic", 55000));
            empList.Add(new Employee("Mil", 70000));
            
            // Inspect some list properties
            Console.WriteLine($"empList capacity is {empList.Capacity}"); // 10
            Console.WriteLine($"empList count is {empList.Count}"); // 4
            
            // Use Exists()
            if (empList.Exists(HighPay))
            {
                Console.WriteLine("Highly paid employee found!");
            }
            
            // Use Find()
            Employee e = empList.Find(x => x.mName.StartsWith("J")); // inline lambda function to find first employee in empList that starts with letter j
            if (e != null)
            {
                Console.WriteLine($"Found employee whose name starts with J: {e.mName} ");
            }
            
            // Use ForEach
            empList.ForEach(TotalSalaries);
            Console.WriteLine($"Total payroll is {total}");
            
        }
        
        // delegate below is used to facilitate search for employees with high pay (for Exists usage example above)
        static Boolean HighPay(Employee emp)
        {
            return emp.mSalary >= 65000;
        }
        
        // iterator function for ForEach method example above
        static int total = 0;
        static void TotalSalaries(Employee e)
        {
            total += e.mSalary;
        }
    }
}