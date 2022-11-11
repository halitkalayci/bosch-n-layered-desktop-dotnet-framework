using Business.Request.User;
using Entities.Concretes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Bosch.MVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public async Task<ActionResult> Index()
        {
            using(HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44399/api/users";

                var response = await client.GetAsync(url);

                var content = await response.Content.ReadAsStringAsync();

                List<User> users = JsonConvert.DeserializeObject<List<User>>(content);
                return View(users);
            }
        }

        public async Task<ActionResult> Details(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://localhost:44399/api/users/{id}";
                // Header kullanılacaksa =>
                //client.DefaultRequestHeaders.Add("Id", id.ToString());
                var response = await client.GetAsync(url);

                var content = await response.Content.ReadAsStringAsync();

                User user = JsonConvert.DeserializeObject<User>(content);
                return View(user);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateUserRequest request)
        {
            using(HttpClient client = new HttpClient())
            {
                string url = "https://localhost:44399/api/users";

                var jsonRequest = JsonConvert.SerializeObject(request);

                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                    return RedirectToAction("Index");

                return RedirectToAction("Create");
            }
        }
    }
}