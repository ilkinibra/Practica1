using Json.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://jsonplaceholder.typicode.com/users").Result;
            var responseJsonStr = response.Content.ReadAsStringAsync().Result;
           
            List<User> user1 = JsonConvert.DeserializeObject<List<User>>(responseJsonStr);
            foreach (var item in user1)
            {
              Console.WriteLine(item.Name);
            }
        }
    }
}
