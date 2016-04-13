namespace Proxy
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using DataModel;
    using DataModel.Enum;

    public class ItemAttributeProxy : IItemAttributeProxy
    {
        public async Task<List<ItemAttribute>> GetList(string rootUrl, string apiUrl)
        {
            List<ItemAttribute> list = new List<ItemAttribute>();

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
                        list = await response.Content.ReadAsAsync<List<ItemAttribute>>();
                        return list;
                    }
                }
                catch (Exception ex)
                {
                    /* exception handling required */
                    return null;
                }
            }

            return null;
        }

        public async Task<ItemAttribute> GetItem(string rootUrl, string apiUrl, int id)
        {
            ItemAttribute item = new ItemAttribute();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(rootUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync(string.Format("{0}/{1}", apiUrl, id));
                    if (response.IsSuccessStatusCode)
                    {
                        item = await response.Content.ReadAsAsync<ItemAttribute>();
                        return item;
                    }
                }
                catch (Exception ex)
                {
                    /* exception handling required */
                    return null;
                }
            }

            return null;
        }

        public async Task<string> UpdateAttribute(string rootUrl, string apiUrl, ItemAttribute attribute)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(rootUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var values = new Dictionary<string, string>()
                        {
                            {"AttributeId", attribute.AttributeId.ToString()},
                            {"AttributeName", attribute.AttributeName}
                        };

                    var content = new FormUrlEncodedContent(values);
                    var response = await client.PutAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        return Result.Success.ToString();
                    }
                    else
                    {
                        return Result.Failure.ToString();
                    }
                }
                catch (Exception ex)
                {
                    /* exception handling required */
                    return Result.Exception.ToString();
                }
            }
        }
    }
}
