using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolBusRegistration.Core.Services;
using SchoolBusRegistration.Core.ViewModels;

namespace SchoolBusRegistration.Web.Controllers
{
    public class TransportRequestsController : Controller
    {
        private readonly IGradeService gradeService;
        private readonly ITransportRequestService transportRequestService;

        public TransportRequestsController(IGradeService gradeService, ITransportRequestService transportRequestService)
        {
            this.gradeService = gradeService;
            this.transportRequestService = transportRequestService;
        }
        // GET: TransportRequestsController
        public ActionResult Index()
        {
            var requests = transportRequestService.GetTransportRequests();
            return View("DisplayAll",requests);
        }

        public ActionResult Report()
        {
            var requests = transportRequestService.GetTransportRequests();
            return View(requests);
        }


        // GET: TransportRequestsController/Create
        public ActionResult Create()
        {
            var form = new TransportRequestFormViewModel();
            form.Grades = gradeService.GetGrades();
            return View(form);
        }

        // POST: TransportRequestsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] TransportRequestFormViewModel form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    transportRequestService.AddTransportRequest(form);
                    return RedirectToAction(nameof(Report));
                }
            }
            catch
            {
            }
                form.Grades = gradeService.GetGrades();
            form.HasErrors = true;
                return View(form);
        }

        public ActionResult Details(int id)
        {
            var model = transportRequestService.GetTransportRequest(id);
            return View(model);
        }
    }
}
