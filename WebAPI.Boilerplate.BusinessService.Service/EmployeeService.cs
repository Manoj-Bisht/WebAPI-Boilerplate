using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Boilerplate.BusinessService.Interface;
using WebAPI.Boilerplate.DataService;
using WebAPI.Boilerplate.DataService.Interface;
using WebAPI.Boilerplate.Logger;

namespace WebAPI.Boilerplate.BusinessService.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRespository employeeRepository;
        private readonly BaseLogger baseLogger;
        public EmployeeService(IEmployeeRespository employeeRepository, BaseLogger baseLogger)
        {

            this.employeeRepository = employeeRepository;
            this.baseLogger = baseLogger;
        }

        public Model.Employee GetEmployee(int employeeId)
        {
            this.baseLogger.Logger.Debug("Test from business service");
            return this.employeeRepository.GetEmployee(employeeId);
        }
    }
}
