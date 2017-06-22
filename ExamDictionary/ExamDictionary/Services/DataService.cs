using ExamDictionary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExamDictionary.Services
{
    public class DataService
    {
        private static readonly DataService _instance = new DataService();
        private HttpClient _client = new HttpClient();

        private readonly string _baseUrl = "https://dictionary.yandex.net/api/v1/dicservice.json/lookup";
        private readonly string _apiKey = "dict.1.1.20170523T080830Z.ee3adc727060e18c.9da193c27a928ec08142f189ad69977cddca6e11";

        public static DataService GetInstance()
        {
            return _instance;
        }

        public async Task<ResponseModel> TranslateAsync(string lang, string text)
        {
            try
            {
                var response = await _client.PostAsync($"{_baseUrl}?key={_apiKey}&lang={lang}&text={text}", new StringContent("", Encoding.UTF8, "application/json"));
                var responseBody = await response.Content.ReadAsStringAsync();
                var responseJson = JsonConvert.DeserializeObject<ResponseModel>(responseBody);
                return responseJson;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return new ResponseModel { };
            }
        }
    }
}
