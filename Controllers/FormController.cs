using FormMail.Entities;
using FormMail.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace FormMail.Controllers
{
    public class FormController : Controller
    {
        private readonly FormDbcontext dbContext;
        public FormController(FormDbcontext dbcontext)
        {
            this.dbContext = dbcontext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FormModel obj)
        {
            var formModel = new FormModel
            {
                Id = obj.Id,
                Name = obj.Name,
                ToMail = obj.ToMail,
                Subject = obj.Subject,
                Message = obj.Message,
            };
            dbContext.FormTable.Add(formModel);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
