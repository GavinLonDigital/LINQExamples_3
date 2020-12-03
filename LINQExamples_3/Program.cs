using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LINQExamples_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments(employeeList);

            ////Equality Operator
            ////SequenceEqual
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6 };

            //var boolSequenceEqual = integerList1.SequenceEqual(integerList2);

            //Console.WriteLine(boolSequenceEqual);
            //var employeeListCompare = Data.GetEmployees();
            //bool boolSE = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());

            //Console.WriteLine($"Result: {boolSE}");

            ////Concatenation Operator
            ////Concat

            //List<int> integerList1 = new List<int> { 1, 2, 3, 4 };
            //List<int> integerList2 = new List<int> { 5, 6, 7, 8, 9, 10 };

            //IEnumerable<int> integerListConcat = integerList1.Concat(integerList2);

            //foreach (var item in integerListConcat)
            //    Console.WriteLine(item);

            //List<Employee> employeeList2 = new List<Employee> { new Employee { Id = 5, FirstName = "Tony", LastName = "Stark" }, new Employee { Id = 6, FirstName = "Debbie", LastName = "Townsend" } };

            //IEnumerable<Employee> results = employeeList.Concat(employeeList2);

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Aggregate Operators - Aggregate, Average, Count, Sum, Max
            ////Aggregate Operator

            //decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totAnnualSalary, e) =>
            //{
            //    var bonus = (e.IsManager) ? 0.04m : 0.02m;

            //    totAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totAnnualSalary;

            //    return totAnnualSalary;
            //});

            //Console.WriteLine($"Total Annual Salary of all employees (including bonus): {totalAnnualSalary}");

            //string data = employeeList.Aggregate<Employee,string, string>("Employee Annual Salaries (including bonus): ",
            //    (s, e) => {
            //        var bonus = (e.IsManager) ? 0.04m : 0.02m;

            //        s += $"{e.FirstName} {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}, ";
            //        return s;
            //    }, s => s.Substring(0, s.Length - 2)
            //);

            //Console.WriteLine(data);

            ////Average
            //decimal average = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);

            //Console.WriteLine($"Average Annual Salary (Technology Department): {average}");

            ////Count
            //int countEmployees = employeeList.Count(e => e.DepartmentId == 3);

            //Console.WriteLine($"Number of Employees (Technology Department): {countEmployees}");

            ////Sum
            //decimal result = employeeList.Sum(e => e.AnnualSalary);
            //Console.WriteLine($"Total Annual Salaries: {result}");

            ////Max
            //var result = employeeList.Max(e => e.AnnualSalary);
            //Console.WriteLine($"Highest Annual Salary: {result}");

            ////Generation Operators - DefaultIfEmpty, Empty, Range, Repeat
            ////DefaultIfEmpty
            //List<int> intList = new List<int>();
            //var newList = intList.DefaultIfEmpty();

            //Console.WriteLine(newList.ElementAt(0));

            //List<Employee> employees = new List<Employee>();
            //var newList = employees.DefaultIfEmpty(new Employee { Id = 0});

            //var result = newList.ElementAt(0);

            //if (result.Id == 0)
            //    Console.WriteLine($"The list is empty");

            ////Empty
            //List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();

            //emptyEmployeeList.Add(new Employee {Id = 7,FirstName="Dan", LastName="Brown" });

            //foreach (var item in emptyEmployeeList)
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");

            ////Range
            //var intCollection = Enumerable.Range(25, 20);
            //foreach (var item in intCollection)
            //    Console.WriteLine(item);

            ////Repeat
            //var strCollection = Enumerable.Repeat<string>("Placeholder", 10);
            //foreach (var item in strCollection)
            //    Console.WriteLine(item);

            ////Set Operators - Distinct, Except, Intersect, Union
            ////Distinct

            //List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7 };
            //var results = list.Distinct();
            //foreach (var item in results)
            //    Console.WriteLine(item);

            ////Except

            //IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
            //IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6};

            //var results = collection1.Except(collection2);
            //foreach (var item in results)
            //    Console.WriteLine(item);

            //List<Employee> employeeList2 = new List<Employee>();

            //employeeList2.Add(new Employee
            //    {
            //        Id = 1,
            //        FirstName = "Bob",
            //        LastName = "Jones",
            //        AnnualSalary = 60000.3m,
            //        IsManager = true,
            //        DepartmentId = 2
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 3,
            //        FirstName = "Douglas",
            //        LastName = "Roberts",
            //        AnnualSalary = 40000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 5,
            //        FirstName = "Craig",
            //        LastName = "Laurence",
            //        AnnualSalary = 20000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    }
            //);
            //employeeList2.Add(new Employee
            //    {
            //        Id = 6,
            //        FirstName = "Elizabeth",
            //        LastName = "Tate",
            //        AnnualSalary = 85000,
            //        IsManager = true,
            //        DepartmentId = 1
            //    }
            //);

            //var results = employeeList.Except(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Intersect
            //var results = employeeList.Intersect(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Union
            //var results = employeeList.Union(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Partitioning Operators - Skip, SkipWhile, Take, TakeWhile
            ////Skip

            //var results = employeeList.Skip(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////SkipWhile

            //employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000.0m });

            //var results = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Take
            //var results = employeeList.Take(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////TakeWhile

            //employeeList.Add(new Employee { Id = 5, FirstName = "Sam", LastName = "Davis", AnnualSalary = 100000 });

            //var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Conversion Operators - ToList, ToDictionary, ToArray
            ////ToList

            //List<Employee> results = (from emp in employeeList
            //                         where emp.AnnualSalary > 50000
            //                         select emp).ToList();

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////ToDictionary

            //Dictionary<int, Employee> dictionary = (from emp in employeeList
            //                                        where emp.AnnualSalary > 50000
            //                                        select emp).ToDictionary<Employee, int>(e => e.Id);

            //foreach (var key in dictionary.Keys)
            //    Console.WriteLine($"Key: {key}, Value: {dictionary[key].FirstName} {dictionary[key].LastName}");

            ////ToArray
            //Employee[] results = (from emp in employeeList
            //                      where emp.AnnualSalary > 50000
            //                      select emp).ToArray();

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Let Clause and Into Clause

            ////Let
            //var results = from emp in employeeList
            //              let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
            //              let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
            //              where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
            //              select new
            //              {
            //                  Initials = Initials,
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalaryPlusBonus = AnnualSalaryPlusBonus
            //              };

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Initials,-5} {item.FullName,-20} {item.AnnualSalaryPlusBonus,10}");

            ////Into
            //var results = from emp in employeeList
            //              where emp.AnnualSalary > 50000
            //              select emp
            //              into HighEarners
            //              where HighEarners.IsManager == true
            //              select HighEarners;

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");

            ////Projection Operators - Select, SelectMany
            ////Select
            //var results = departmentList.Select(d => d.Employees);

            //foreach(var items in results)
            //    foreach(var item in items)
            //        Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");

            ////SelectMany
            //var results = departmentList.SelectMany(d => d.Employees); //.OrderBy(o => o.Id);

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}\t{item.IsManager}");


            Console.ReadKey();

        }
    }
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals([AllowNull] Employee x, [AllowNull] Employee y)
        {
            if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public IEnumerable<Employee> Employees { get; set; }

    }
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 3
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000.2m,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments(IEnumerable<Employee> employees)
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources",
                Employees = from emp in employees
                            where emp.DepartmentId == 1
                            select emp

            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance",
                Employees = from emp in employees
                            where emp.DepartmentId == 2
                            select emp
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology",
                Employees = from emp in employees
                            where emp.DepartmentId == 3
                            select emp
            };
            departments.Add(department);

            return departments;
        }

    }
}
