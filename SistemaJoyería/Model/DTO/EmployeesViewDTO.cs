using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaJoyería.Model.DTO
{
    internal class EmployeesViewDTO : dbContext
    {
        private int idEmployee;

        private string employeeFirstName;

        private string employeelastName;

        private string employeePhone;

        private string employeeEmail;

        private DateTime employeeBirthDate;

        private string employeeDUI;

        private string employeeAddress;

        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string EmployeeFirstName { get => employeeFirstName; set => employeeFirstName = value; }
        public string EmployeelastName { get => employeelastName; set => employeelastName = value; }
        public string EmployeePhone { get => employeePhone; set => employeePhone = value; }
        public string EmployeeEmail { get => employeeEmail; set => employeeEmail = value; }
        public DateTime EmployeeBirthDate { get => employeeBirthDate; set => employeeBirthDate = value; }
        public string EmployeeDUI { get => employeeDUI; set => employeeDUI = value; }
        public string EmployeeAddress { get => employeeAddress; set => employeeAddress = value; }
    }
}
