using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Surgeon : Doctor
    {
        protected bool isOperating;

        public bool IsOperating
        {
            get { return this.isOperating; }
            set { this.isOperating = value; }
        }

        public Surgeon()
        {

        }
        public Surgeon (string employeeName, int employeeNum, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialtyArea = specialtyArea;

            this.isOperating = false;
        }

    }
}
