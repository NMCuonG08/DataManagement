using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Database
{
    internal class Employee
    {
        private int employeID;
        private string name;
        private string address;
        private DateTime birthday;
        private string phoneNumber;
        private string email;
        private string idcard;
        private string gender;
        private int DepartmentID;
        private string position;
        private byte[] _EmployeeImage;
        public Employee() { }
        public Employee(int employeID, string name, string address, DateTime birthday, string phoneNumber, string email, string idcard, string gender, int departmentID, string position, byte[] employeeImage)
        {
            this.EmployeID = employeID;
            this.Name = name;
            this.Address = address;
            this.Birthday = birthday;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Idcard = idcard;
            this.Gender = gender;
            this.DepartmentID1 = departmentID;
            this.Position = position;
            this.EmployeeImage = employeeImage;
        }

        public int EmployeID { get => employeID; set => employeID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Idcard { get => idcard; set => idcard = value; }
        public string Gender { get => gender; set => gender = value; }
        public int DepartmentID1 { get => DepartmentID; set => DepartmentID = value; }
        public string Position { get => position; set => position = value; }
        public byte[] EmployeeImage { get => _EmployeeImage; set => _EmployeeImage = value; }
    }
}
