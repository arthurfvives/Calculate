using Calculate.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculate.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Calculate()
        {
            return View(new CalculateVM());
        }

        [HttpPost]
        public IActionResult Calculate(CalculateVM viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Result = viewModel.Number1 + viewModel.Number2;
            }
            return View(viewModel);
        }
    }
}
