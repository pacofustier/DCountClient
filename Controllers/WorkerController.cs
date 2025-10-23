using DCountClientMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace DCountClientMvc.Controllers
{
    public class WorkerController(WorkerApiService apiService) : Controller
    {
        private readonly WorkerApiService _workerApiService = apiService;

        public async Task<IActionResult> Index()
        {
            var workers = await _workerApiService.GetAll();
            return View(workers);
        }
    }
}
