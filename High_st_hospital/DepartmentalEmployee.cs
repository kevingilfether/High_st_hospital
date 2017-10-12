using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    abstract class DepartmentalEmployee : Employee
    {
        protected string department;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public DepartmentalEmployee()
        {

        }

    }
}
