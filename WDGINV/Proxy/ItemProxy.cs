namespace Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using DataModel;

    public class ItemProxy : IItemProxy
    {
        /// <summary>
        ///  Implementation to get the list of all the items.
        /// </summary>
        /// <returns>list of all the items.</returns>
        public async Task<List<Item>> GetList(string rootUrl, string apiUrl)
        {
            List<Item> list = new List<Item>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(rootUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        list = await response.Content.ReadAsAsync<List<Item>>();
                    }
                }
                catch (Exception ex)
                {
                    /* exception handling required */
                    return null;
                }
            }

            return list;
        }
    }
}
