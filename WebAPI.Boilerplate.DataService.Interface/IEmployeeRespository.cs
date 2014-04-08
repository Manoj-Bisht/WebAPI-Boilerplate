using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Boilerplate.DataService.Interface
{
    public interface IEmployeeRespository
    {
        Model.Employee GetEmployee(int employeeId);
        
    }
}
