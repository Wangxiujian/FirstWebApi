using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    [RoutePrefix("api/Course1")]
    public class CourseController : ApiController
    {
        SubjectDM[] products = new SubjectDM[]
        {
            new SubjectDM { Id = 1, Name = "Tomato Soup" },
            new SubjectDM { Id = 2, Name = "Yo-yo"},
            new SubjectDM { Id = 3, Name = "Hammer" }
        };

        public IList<SubjectDM> GetAllProducts()
        {
            return products;
        }

        public IEnumerable<SubjectDM> Get(int id)
        {
            return products.Where(product => product.Id == id);
        }
        // GET: api/Course

        // POST: api/Course
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
        }
    }
}
