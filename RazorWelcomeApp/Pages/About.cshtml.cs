using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorWelcomeApp.Pages
{
    public class AboutModel : PageModel
    {
        public string Title { set; get; }
        public string Message { set; get; }
        public Company Company { get; set; }

        public AboutModel()
        {
            Title = "About page";
            Message = "Hello About page content";
        }

        public string GetTime() => DateTime.Now.ToShortTimeString();
        public void OnGet()
        {
            Message = "Input company";
            //Company = new Company() { Title = company.Title, City = company.City };
        }
        public void OnPost(Dictionary<string, string> item)
        {
            Message = "";
            foreach(var i in item)
            {
                Message += i.Key + ": " + i.Value.ToString() + "\n";
            }
            
        }
    }
}
