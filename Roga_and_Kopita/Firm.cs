using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Firma : List<Employee>
    {
        Firma Firm;

        public Firma()
        {
            Firm = null;
        }

        public Firma(string Name,int Age, bool Gender,int Salary, Profession Prof)
        {
            Firm.Add(new Employee(Name, Age, Gender, Salary, Prof));
        }

        public void ADD(string Name, int Age, bool Gender, int Salary, Profession Prof)
        {
            Firm.Add(new Employee(Name, Age, Gender, Salary, Prof));
        }

        //public Employee Edit(int ind)
        //{
        //    return Firm.
        //}

        //public void Delete(int ind)
        //{
        //    Firm.RemoveAt(ind);
        //}

        public static Firma operator -(Firma Firm, int ind)          //перегрузка (удаляем элимент с индексом ind)
        {
            Firm.RemoveAt(ind);
            return Firm;
        }

        public static Firma operator +(Firma Firm, Employee A)       //перегрузка (добавляем работника)
        {
            Firm.Add(A);
            return Firm;
        }

     }
}
