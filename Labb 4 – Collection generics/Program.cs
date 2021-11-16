using System;
using System.Collections.Generic;

namespace Labb_4___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(392, "Daniel", "Male", 10500);
            Employee employee2 = new Employee(182, "Karl", "Male", 10000);
            Employee employee3 = new Employee(931, "Sofia", "Female", 11500);
            Employee employee4 = new Employee(539, "Alexander", "Male", 20500);
            Employee employee5 = new Employee(231, "Elisabeth", "Female", 15500);

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (Employee emp in employeeStack)
            {
                Console.WriteLine(
                    $"Employee ID: {emp._id}" +
                    $"\nEmployee Name: {emp._name}" +
                    $"\nEmployee Gender: {emp._gender}" +
                    $"\nEmployee Salary: {emp._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");
            }

            Console.WriteLine("--------------------------------");

            Employee employeePop1 = employeeStack.Pop();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePop1._id}" +
                    $"\nEmployee Name: {employeePop1._name}" +
                    $"\nEmployee Gender: {employeePop1._gender}" +
                    $"\nEmployee Salary: {employeePop1._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Employee employeePop2 = employeeStack.Pop();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePop2._id}" +
                    $"\nEmployee Name: {employeePop2._name}" +
                    $"\nEmployee Gender: {employeePop2._gender}" +
                    $"\nEmployee Salary: {employeePop2._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Employee employeePop3 = employeeStack.Pop();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePop3._id}" +
                    $"\nEmployee Name: {employeePop3._name}" +
                    $"\nEmployee Gender: {employeePop3._gender}" +
                    $"\nEmployee Salary: {employeePop3._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Employee employeePop4 = employeeStack.Pop();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePop4._id}" +
                    $"\nEmployee Name: {employeePop4._name}" +
                    $"\nEmployee Gender: {employeePop4._gender}" +
                    $"\nEmployee Salary: {employeePop4._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Employee employeePop5 = employeeStack.Pop();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePop5._id}" +
                    $"\nEmployee Name: {employeePop5._name}" +
                    $"\nEmployee Gender: {employeePop5._gender}" +
                    $"\nEmployee Salary: {employeePop5._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("--------------------------------");

            Employee employeePeek1 = employeeStack.Peek();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePeek1._id}" +
                    $"\nEmployee Name: {employeePeek1._name}" +
                    $"\nEmployee Gender: {employeePeek1._gender}" +
                    $"\nEmployee Salary: {employeePeek1._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Employee employeePeek2 = employeeStack.Peek();
            Console.WriteLine(
                    $"\nEmployee ID: {employeePeek2._id}" +
                    $"\nEmployee Name: {employeePeek2._name}" +
                    $"\nEmployee Gender: {employeePeek2._gender}" +
                    $"\nEmployee Salary: {employeePeek2._salary}" +
                    $"\nItems left in the stack: {employeeStack.Count}" +
                    $"\n");

            Console.WriteLine("--------------------------------");

            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine($"\nEmployee 3 with ID number {employee3._id} exists in the stack.");
            }
            else
            {
                Console.WriteLine($"\nEmployee 3 with ID number {employee3._id} does not exist in the stack.");
            }

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            employeeList.Add(employee4);
            employeeList.Add(employee5);

            Console.WriteLine("--------------------------------");

            foreach (Employee emp in employeeList)
            {
                Console.WriteLine(emp._id);
            }
            Console.WriteLine("--------------------------------");
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exist in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            Console.WriteLine("--------------------------------");

            Employee findEmp = employeeList.Find(emp => emp._gender == "Male");
            Console.WriteLine(
                    $"\nEmployee ID: {findEmp._id}" +
                    $"\nEmployee Name: {findEmp._name}" +
                    $"\nEmployee Gender: {findEmp._gender}" +
                    $"\nEmployee Salary: {findEmp._salary}" +
                    $"\n");

            Console.WriteLine("--------------------------------");

            List<Employee> findEmp2 = employeeList.FindAll(emp2 => emp2._gender == "Male");
            foreach (Employee emp in findEmp2)
            {
                Console.WriteLine(
                     $"\nEmployee ID: {emp._id}" +
                     $"\nEmployee Name: {emp._name}" +
                     $"\nEmployee Gender: {emp._gender}" +
                     $"\nEmployee Salary: {emp._salary}" +
                     $"\n");
            }
        }
    }
}
