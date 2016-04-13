namespace Proxy
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using DataModel;

    /// <summary>
    /// Interface for the class item business logic
    /// </summary>
    interface IItemProxy
    {
        /// <summary>
        /// Method to get the list of all the items.
        /// </summary>
        /// <returns>List of all items</returns>
        Task<List<Item>> GetList(string rootUrl, string actionUrl);
    }
}
