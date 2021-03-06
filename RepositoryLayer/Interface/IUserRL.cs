using CommonLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
   public interface IUserRL
    {
      int AddEmployee(EmployeeContract employeeContract);
        IList<EmployeeContract> GetAllEmployees();
        int UpdateEmployee(EmployeeContract employeeContract, int Id);
        EmployeeContract GetById(int Id);
        int DeleteEmployee(int Id);
    }
}
