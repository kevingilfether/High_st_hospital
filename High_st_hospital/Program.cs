using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_st_hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up lists of employees
            List<Employee> employeeList = new List<Employee>();
            List<Doctor> doctorList = new List<Doctor>();
            List<Surgeon> surgeonList = new List<Surgeon>();
            List<Nurse> nurseList = new List<Nurse>();
            List<Receptionist> receptionistList = new List<Receptionist>();

            //copy for hospital management system
            Console.WriteLine("Welcome to High St. Hospital Personnel Managment System.");
            Console.WriteLine("(HSHPMS)");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("LOOKUP or ADD");
            string action = Console.ReadLine().Trim().ToUpper();

            bool isDoneAdding = true;
            if (action == "ADD")
                isDoneAdding = false;

            while (!isDoneAdding)
            {
                Console.WriteLine();
                Console.WriteLine("Add an Employee");
                Console.WriteLine("What kind of employee do you want to add?");
                Console.Write("DOCTOR - SURGEON - NURSE - RECEPTIONIST - OTHER - DONE");
                string employeeType = Console.ReadLine().Trim().ToUpper();
                switch (employeeType)
                {
                    case "DOCTOR":
                        Console.WriteLine("What is the employee's name?");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("What is the employee's ID number?");
                        int employeeNum = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the doctor's area of specialty?");
                        string specialtyArea = Console.ReadLine();
                        doctorList.Add(new Doctor(employeeName, employeeNum, specialtyArea));
                        break;

                    case "SURGEON":
                        break;

                    case "NURSE":
                        break;

                    case "RECEPTIONIST":
                        break;

                    case "DONE":
                        break;

                    default:
                        break;

                }
            }
        }
    }
}
