using Lindsey.Models;
using System.Linq;
using System.Web.Mvc;

namespace Lindsey.Controllers
{
    public class HomeController : Controller
    {
        SkiingEntities db = new SkiingEntities();
        public ActionResult Index()
        {

            //db.States.ToList(x=>(form.State == null || form.State == x.State)
            var model = new ResortViewModel();
            model.States.Add(new SelectListItem { Value = "NH", Text = "New Hampshire" });
            model.States.Add(new SelectListItem { Value = "ME", Text = "Maine" });

            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ResortViewModel form)
        {
            //var model = db.Resorts.Where(x => (form.State == null || form.State == x.State)
            //    && form.ResortName == null || x.ResortName.Equals(form.ResortName, System.StringComparison.CurrentCultureIgnoreCase)).ToList<Resort>();
            return RedirectToAction("List", form);
        }
        public ActionResult List(ResortViewModel form)
        {
            var model = db.Resorts.Where(x => (form.State == null || form.State == x.State)
               && form.ResortName == null || x.ResortName.Equals(form.ResortName, System.StringComparison.CurrentCultureIgnoreCase)).ToList<Resort>();
            return View(model);

            //Link the data to the ticket table for holiday deals

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}