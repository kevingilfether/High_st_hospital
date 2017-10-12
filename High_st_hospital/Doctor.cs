using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Doctor : Employee
    {
        protected string specialtyArea;

        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }


        public Doctor()
        {

        }

        public Doctor(string employeeName, int employeeNum, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialtyArea = specialtyArea;
        }
}
