using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Nurse : DepartmentalEmployee
    {
        protected int numOfPatients;

        public int NumOfPatients
        {
            get { return this.numOfPatients; }
            set { this.numOfPatients = value; }
        }

        public Nurse()
        {

        }

        public Nurse(string employeeName, int employeeNum, string department, int numOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;
            this.numOfPatients = numOfPatients;
        }
}
