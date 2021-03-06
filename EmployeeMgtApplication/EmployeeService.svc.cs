using BusinessLayer.Interface;
using BusinessLayer.Service;
using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeMgtApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly IUserBL userBL;
        public EmployeeService()
        {
            userBL = new UserBL();
        }

        public string AddEmployee(EmployeeContract employeeContract)
        {
            try
            {
                return userBL.AddEmployee(employeeContract);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public EmployeeContract GetById(string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.GetById(empId);
        }

        public IList<EmployeeContract> GetAllEmployees()
        {
            return userBL.GetAllEmployees();
        }

        public string UpdateEmployee(EmployeeContract employeeContract, string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.UpdateEmployee(employeeContract, empId);
        }

        public string DeleteEmployee(string Id)
        {
            int empId = Convert.ToInt32(Id);
            return userBL.DeleteEmployee(empId);
        }
    }
}
