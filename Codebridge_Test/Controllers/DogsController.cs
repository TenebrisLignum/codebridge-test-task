﻿using Codebridge_Test.Services.Interfaces;
using Codebridge_Test.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Codebridge_Test.Controllers
{
    public class DogsController : Controller
    {
        private readonly IDogsService _dogService;
        public DogsController(IDogsService dogService)
        {
            _dogService = dogService;
        }

        public async Task<IActionResult> Index(DogTableFilterViewModel filter)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var table = await _dogService.GetTable(filter);

            return View(table);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(DogViewModel dog)
        {
            if (!ModelState.IsValid)
                return View(dog);

            if (await _dogService.IsDogExist(dog.Name))
            {
                ModelState.AddModelError(nameof(dog.Name), "A dog with that name already exists");
                return View(dog);
            }

            await _dogService.Create(dog);
            return RedirectToAction("Index");
        }
    }
}
