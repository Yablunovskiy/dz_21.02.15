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

        public void Delete(int ind)
        {
            Firm.RemoveAt(ind);
        }

    }
}
