using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{

    public struct Profession
    {
        public string Prof;
        public int id;
    }

    class Employee
    {
        string Name;
        int Age;
        bool Gender;
        int Salary;
        Profession proffes;

        public Employee()
        {
            Name = "";
            Age = Salary = 0;
            Gender = false;
            proffes.Prof = "";
            proffes.id = 0;
        }

        public Employee(string Name, int Age, bool Gender, int Salary, Profession Prof)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Salary = Salary;
            this.proffes = Prof;
        }

    }
}
