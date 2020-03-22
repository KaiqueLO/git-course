using System;
using System.Globalization;

namespace Listas
{
    public class Employee
    {
        #region Prpriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        #endregion'

        #region Metodos
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage/100;
        }

        public override string ToString()
        {
            return Id + "," + Name + ',' + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        #endregion
    }
}