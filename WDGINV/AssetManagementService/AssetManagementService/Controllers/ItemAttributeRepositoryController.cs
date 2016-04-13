namespace AssetManagementService.Controllers
{
    using DataModel;
    using DataModel.Enum;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public class ItemAttributeRepositoryController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ItemAttribute> Get()
        {
            using (var context = new AssetManagementEntities())
            {
                var attributes = context.ItemAttributes.ToList();
                return attributes;
            }
        }

        // GET api/<controller>/5
        public ItemAttribute Get(int id)
        {
            using (var context = new AssetManagementEntities())
            {
                var attribute = context.ItemAttributes.FirstOrDefault(a => a.AttributeId == id);
                return attribute;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public string Put([FromBody]ItemAttribute attribute)
        {
            using (var context=new AssetManagementEntities())
            {
                var itemAttribute = context.ItemAttributes.FirstOrDefault(a => a.AttributeId == attribute.AttributeId);
                itemAttribute.AttributeName = attribute.AttributeName;
                context.SaveChanges();
                return Result.Success.ToString();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}