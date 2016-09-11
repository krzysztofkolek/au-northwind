namespace ProgramistaNorthwind.Controllers
{
    using EF;
    using EF.Repository;
    using Microsoft.AspNetCore.Mvc;
    using Models.Employees;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private EmployeeRepository _repo { get; set; }

        public EmployeesController(NorthwindContext context)
        {
            _repo = new EmployeeRepository(context);
        }

        // GET api/employee
        [HttpGet]
        public IEnumerable<EmployeeIndex> GetIndex()
        {
            return _repo.GetAll().Select(item => new EmployeeIndex()
            {
                Id = item.EmployeeID,
                Name = string.Format("{0} {1}", item.FirstName, item.LastName),
                DateOfhire = (item.HireDate.HasValue) ? item.HireDate.Value.ToString() : "",
                JobTitle = item.Title
            });
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public EmployeeDetails Get(string id)
        {
            var repositoryResult = _repo.Get(id);

            byte[] photo = repositoryResult.Photo;
            string imageSrc = null;
            if (photo != null)
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(photo, 78, photo.Length - 78);
                string imageBase64 = Convert.ToBase64String(ms.ToArray());
                imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
            }
         


            return new EmployeeDetails()
            {
                FirstName = repositoryResult.FirstName,
                LastName = repositoryResult.LastName,
                JobTitle = repositoryResult.Title,
                DateOfHire = repositoryResult.HireDate.Value.ToString(),   
                Image = imageSrc
            };
        }
    }
}
