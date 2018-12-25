using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin_CSharp
{
     class Program
     {
          public class Employee
 {
 private string firstName;
 private string lastName;
 private static int count; // Employee objects in memory

 // constructor increments static Employee count
 public Employee(string fName, string lName)
 {
 firstName = fName;
 lastName = lName;

 ++count;

 Console.WriteLine( "Employee object constructor: " +
 firstName + " " + lastName + "; count = " + Count );
 }

 // destructor decrements static Employee count
~Employee()
 {
--count;
                     Console.WriteLine("Employee object destructor: " +
 firstName + " " + lastName + "; count = " + Count);
                     }

 // FirstName property
 public string FirstName
 {
 get
 {
 return firstName;
 }
 }

 // LastName property
 public string LastName
 {
 get
 {
 return lastName;
 }
 }

 // static Count property
 public static int Count
 {
 get
 {
 return count;
 }
 }

 }
          static void Main(string[] args)
          {
               Console.WriteLine("Employees before instantiation: " +
 Employee.Count + "\n");
               
 // create two Employees
 Employee employee1 = new Employee("Susan", "Baker");
                Employee employee2 = new Employee("Bob", "Jones"); 

 Console.WriteLine("\nEmployees after instantiation: " +
 "Employee.Count = " + Employee.Count + "\n");
               
 // display the Employees
 Console.WriteLine("Employee 1: " +
 employee1.FirstName + " " + employee1.LastName +
 "\nEmployee 2: " + employee2.FirstName +
 " " + employee2.LastName + "\n");
               
 // remove references to objects to indicate that
 // objects can be garbage collected
 employee1 = null;
                employee2 = null;
               
 // force garbage collection
 System.GC.Collect();
               
 // wait until collection completes
 System.GC.WaitForPendingFinalizers();
               
 Console.WriteLine(
 "\nEmployees after garbage collection: " +
 Employee.Count);
               Console.ReadKey();
                }
 }
}
     

