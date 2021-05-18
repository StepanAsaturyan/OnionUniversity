using Interfaces;
using Microsoft.AspNetCore.Mvc;
using OnionUniversity.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionUniversity.Controllers
{
    public class SearchController : Controller
    {
        private readonly IStudentRepository _repository;
        private readonly Task6Context _db;

        public SearchController(IStudentRepository repository)
        {
            _repository = repository;
            _db = new Task6Context();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Find(string namePart)
        {
            var students = _repository.GetStudentListByName(namePart);

            return View(students);
        }
    }
}
