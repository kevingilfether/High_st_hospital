using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Employee
    {
        //This is the general, non-abstract employee class
        //It is the the superclass to everything else

        //fields
        protected string employeeName;
        protected int employeeNum;

        //Properties

        public string EmployeeName
        {
            get { return this.employeeName; }
        }
        public int EmployeeNum
        {
            get { return this.employeeNum; }
        }

        public Employee()
        {

        }
        public Employee(string employeeName, int employeeNum)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
        }
    }

}