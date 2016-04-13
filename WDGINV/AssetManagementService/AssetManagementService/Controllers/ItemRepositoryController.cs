using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;

namespace AssetManagementService.Controllers
{
    public class ItemRepositoryController : ApiController
    {
        // GET api/itemrepository
        public IEnumerable<Item> Get()
        {
            using (var context = new AssetManagementEntities())
            {
                var items = context.Items.ToList();
                return items;
            }
        }

        // GET api/itemrepository/5
        public Item Get(int id)
        {
            using (var context = new AssetManagementEntities())
            {
                return context.Items.FirstOrDefault(a => a.ItemId == id);
            }
        }

        // POST api/itemrepository
        public void Post([FromBody]string value)
        {
        }

        // PUT api/itemrepository/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/itemrepository/5
        public void Delete(int id)
        {
        }

    }
}
