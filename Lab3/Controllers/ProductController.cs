using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab3
{
    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<TableProduct> Get()
        {
            using (TableProductEntities productEntities = new TableProductEntities())
            {
                return productEntities.TableProducts.ToList();
            }
        }

        // GET api/product/valid
        //public IEnumerable<TableProduct> Get(DateTime date)
        //{
        //    using (TableProductEntities productEntities = new TableProductEntities())
        //    {
        //        return productEntities.TableProducts.Where();
        //    }
        //}

        // GET api/<controller>/5
        public TableProduct Get(int id)
        {
            using (TableProductEntities productEntities = new TableProductEntities())
            {
                return productEntities.TableProducts.Find(id);
            }
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}