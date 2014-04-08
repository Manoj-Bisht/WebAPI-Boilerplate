using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Boilerplate.Model;

namespace WebAPI.Boilerplate.BusinessService.Interface
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int employeeId);
    }
}
