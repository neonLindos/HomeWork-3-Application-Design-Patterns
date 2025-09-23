using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.task2
{
 

    public interface IEmployee
    {
        string Name { get; set; }
        double BaseSalary { get; set; }
        double CalculateSalary();
    }

    public class PermanentEmployee : IEmployee
    {
        public string Name { get; set; } = "Unknown";
        public double BaseSalary { get; set; } = 4000;

        public double CalculateSalary() => BaseSalary * 1.2;
    }

    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; } = "Unknown";
        public double BaseSalary { get; set; } = 3000;

        public double CalculateSalary() => BaseSalary * 1.1;
    }

    public class Intern : IEmployee
    {
        public string Name { get; set; } = "Unknown";
        public double BaseSalary { get; set; } = 1000;

        public double CalculateSalary() => BaseSalary * 0.8;
    }

    public class Freelancer : IEmployee
    {
        public string Name { get; set; } = "Unknown";
        public double BaseSalary { get; set; } = 1500;

        public double CalculateSalary() => BaseSalary * 0.9;
    }

}
