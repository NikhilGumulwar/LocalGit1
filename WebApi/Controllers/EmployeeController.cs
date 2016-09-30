using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using EmpDataAccess;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDataEntities entities = new EmployeeDataEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDataEntities entities = new EmployeeDataEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }

        [Route("{id:int}/details")]
        public Employee GetEmployee(int id)
        {
            using (EmployeeDataEntities entities = new EmployeeDataEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }

    }
}
