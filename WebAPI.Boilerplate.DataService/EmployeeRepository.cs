using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Boilerplate.DataService.Interface;
using WebAPI.Boilerplate.Logger;

namespace WebAPI.Boilerplate.DataService
{
    public class EmployeeRepository : IEmployeeRespository
    {
        private readonly BaseLogger baseLogger;
        public EmployeeRepository(BaseLogger baseLogger)
        {
            this.baseLogger = baseLogger;
        }

        public Model.Employee GetEmployee(int employeeId)
        {
            this.baseLogger.Logger.Debug("Test from repository service");
            return new Model.Employee { Id = 1, Name = "Employee Name", Salary = 120000 };
        }
    }
}
