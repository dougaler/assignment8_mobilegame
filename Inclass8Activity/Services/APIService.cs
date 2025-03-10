using Inclass8Activity.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass8Activity.Services
{
	public class APIService
	{
		public async Task<Root> GetNews(string categoryName)
		{
			var httpClient = new HttpClient();
			var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=5e4b97eac9cbc750bd09b455cb8d48bf&lang=en");
			return JsonConvert.DeserializeObject<Root>(response);
		}
	}
}
