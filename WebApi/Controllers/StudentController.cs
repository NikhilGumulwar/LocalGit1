using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpDataAccess;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDataEntities entities = new EmployeeDataEntities())
            {
                Console.WriteLine("In Student Controller");
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (EmployeeDataEntities entities = new EmployeeDataEntities())
            {
                Console.WriteLine("In Student Controller for particular stud");
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
