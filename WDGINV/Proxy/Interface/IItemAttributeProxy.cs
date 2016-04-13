namespace Proxy
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DataModel;

    /// <summary>
    /// Item Attribute Proxy interface
    /// </summary>
    interface IItemAttributeProxy
    {
        /// <summary>
        /// Get list of all the item attributes
        /// </summary>
        /// <returns>list of all item attributes</returns>
        Task<List<ItemAttribute>> GetList(string rootUrl, string actionUrl);
    }
}
