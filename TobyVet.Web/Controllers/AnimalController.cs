using Microsoft.AspNetCore.Mvc;
using TobyVet.Core.Services;

namespace TobyVet.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalService _animalService;

        public AnimalController(AnimalService animalService)
        {
            _animalService = animalService;
        }

    }
}