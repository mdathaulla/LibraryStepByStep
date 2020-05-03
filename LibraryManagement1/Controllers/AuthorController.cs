﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement1.Data.Interface;
using LibraryManagement1.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement1.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [Route("Author")]
        public IActionResult List()
        {
            var author = _authorRepository.GetAllwithBooks();
            if (author.Count() == 0)
            {
                return View("Empty");
            }
            return View(author);
        }
        public IActionResult Delete(int id)
        {
            var author = _authorRepository.GetById(id);
            _authorRepository.Delete(author);
            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            _authorRepository.Create(author);
            return RedirectToAction("List");
        }
        public IActionResult Update(int id)
        {
            var author = _authorRepository.GetById(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Update(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            _authorRepository.Update(author);
            return RedirectToAction("List");
        }
    }
}