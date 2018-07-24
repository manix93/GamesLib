using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using GamesLib.Secret_Data;
using Newtonsoft.Json;

namespace GamesLib.Models
{
    public class TranslateWebApi
    {
        public const string BaseUrl = "https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&lang={1}&text={2}";
        

        public static async Task<Translate> GetTranslatedTextAsync(string lang, string text)
        {
            Translate translate;
            using (var httpClient = new HttpClient())
            {
                var fullUrl = string.Format(BaseUrl, API_KEYS.ApiKey, lang, text);
                var response = httpClient.GetAsync(fullUrl).Result;
                var json = await response.Content.ReadAsStringAsync();

                translate = JsonConvert.DeserializeObject<Translate>(json);
            }

            return translate;
        }
    }
}