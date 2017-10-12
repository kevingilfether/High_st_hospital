using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Receptionist : DepartmentalEmployee
    {
        protected bool onPhone;

        public bool OnPhone
        {
            get { return this.onPhone; }
            set { this.onPhone = value; }
        }

        public Receptionist()
        {

        }

        public Receptionist(string employeeName, int employeeNum, string department)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;

            this.onPhone = false;
        }

    }
}
