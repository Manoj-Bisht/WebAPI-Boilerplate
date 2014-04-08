using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Boilerplate.BusinessService.Interface;
using WebAPI.Boilerplate.Logger;

namespace WebAPI.Boilerplate.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService employeeService;
        private readonly BaseLogger baseLogger;


        //private readonly BaseLogger baseLogger;

        public EmployeesController(IEmployeeService employeeService, BaseLogger logger)
        {
            
            this.employeeService = employeeService;
            this.baseLogger = logger;
        }

        // GET api/employee
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/employee/5
        public Model.Employee Get(int id)
        {
            this.baseLogger.Logger.Debug("Test from web api controller");
            return (employeeService.GetEmployee(id));
        }

        // POST api/employee
        public void Post([FromBody]string value)
        {
        }

        // PUT api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
        }
    }
}
