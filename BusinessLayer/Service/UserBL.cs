using BusinessLayer.Interface;
using CommonLayer.Contracts;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserBL : IUserBL
    {
        private readonly IUserRL userRL;

        public UserBL()
        {
            userRL = new UserRL();
        }
        public string AddEmployee(EmployeeContract employeeContract)
        {
            if (userRL.AddEmployee(employeeContract) == 1)
            {
                return "employee added sucessfully";
            }
            else
            {
                return "Employee not added";
            }
        }
        public string UpdateEmployee(EmployeeContract employeeContract, int Id)
        {
            if (userRL.UpdateEmployee(employeeContract, Id) == 1)
            {
                return "Employee updated successfully";
            }
            else
            {
                return "Employee not updated";
            }
        }
        public EmployeeContract GetById(int Id)
        {
            EmployeeContract employeeContract = userRL.GetById(Id);
            if (employeeContract != null)
            {
                return employeeContract;
            }
            else
            {
                return new EmployeeContract();
            }
        }
        public IList<EmployeeContract> GetAllEmployees()
        {
            IList<EmployeeContract> employeeContracts = userRL.GetAllEmployees();
            if (employeeContracts != null)
            {
                return employeeContracts;
            }
            else
            {
                return new List<EmployeeContract>();
            }
        }
        public string DeleteEmployee(int Id)
        {
            if (userRL.DeleteEmployee(Id) == 1)
            {
                return "Employee deleted successfuly";
            }
            else
            {
                return "Employee does not exists.";
            }
        }
    }
}
