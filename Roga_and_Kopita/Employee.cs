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

        public int CompareTo(Employee other)
        {
            if (this.proffes.id > other.proffes.id)
                return 1;
            if (this.proffes.id < other.proffes.id)
                return -1;
            else return 0;
        }

        public static bool operator <(Employee A, Employee B)
        {
            return (A.CompareTo(B)<0);
        }

        public static bool operator >(Employee A, Employee B)
        {
            return (A.CompareTo(B) > 0);
        }

        public string RetProf()
        {
            return this.proffes.Prof;
        }

        /*public override bool Equals(object o)
        {
            return o.ToString()==this.ToString();
        }*/

        public static bool operator ==(Employee A, Employee B)
        {
            return (A.CompareTo(B) == 0);
        }
        public static bool operator !=(Employee A, Employee B)
        {
            return (A.CompareTo(B) != 0);
        }

        public string GetName()
        {
            return Name;
        }

        public string GetGender()
        {
            string p="";
            if (Gender)
                p = "м";
            else p = "ж";
            return p;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetSalary()
        {
            return Salary;
        }

        public string GetProf()
        {
            return proffes.Prof;
        }

        public void SetProf(Profession a)
        {
            this.proffes = a;
        }

        public void Show()
        {
            Console.WriteLine("Name - " + Name + "Age - " + Age + "Gender - " + Gender + "Salary - " + Salary);
        }

    }
}
