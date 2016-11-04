using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Configuration;
using WebAPI_App.Models;

namespace WebAPI_App
{
    public class LibraryServiceProxy
    {
        public static IList<BookModel> GetAllBookDetails()
        {
            IList<BookModel> bookList = new List<BookModel>();
            using (var client = new HttpClient())
            {
                var meeliBaseUrl = WebConfigurationManager.AppSettings["MeeliBaseURL"];
                client.BaseAddress = new Uri(meeliBaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync("api/Library/").Result; // call your webservice
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsAsync<List<BookModel>>().Result;
                    if (result != null)
                    {
                        foreach (var item in result)
                        {
                            bookList.Add(item);
                        }
                    }
                }
            }
            return bookList;
        }

        public static bool AddBook(BookModel bookModel)
        {
             using (var client = new HttpClient())
            {
                var meeliBaseUrl = WebConfigurationManager.AppSettings["MeeliBaseURL"];
                client.BaseAddress = new Uri(meeliBaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //  client.DefaultRequestHeaders.Con

                // HTTP POST
                HttpResponseMessage response = client.PostAsJsonAsync("api/Library/", bookModel).Result; // call your webservice 
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }
}