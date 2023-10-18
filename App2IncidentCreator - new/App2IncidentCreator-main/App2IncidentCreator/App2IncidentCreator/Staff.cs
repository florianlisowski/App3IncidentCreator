using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2IncidentCreator
{
    internal class Staff
    {
        private string staffID;
        private string firstName;
        private string surname;
        private string department;
        


        public Staff(string staffID, string firstName, string surname, string department)
        {
            this.staffID = staffID;
            this.firstName = firstName;
            this.surname = surname;
            this.department = department;
        }
        public string StaffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }


    }
}
