using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnionUniversity.Infrastructure.Data;
using OnionUniversity.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnionUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _repository;
        private readonly Task6Context _db;

        public HomeController(ILogger<HomeController> logger, IStudentRepository repository)
        {
            _logger = logger;
            _repository = repository;
            _db = new Task6Context();
        }

        public IActionResult Index()
        {
            var students = _repository.GetAllStudentList();
            //ViewBag.Students = students;
            return View(students);
        }

        public IActionResult GetStudentsList()
        {
            var students = _repository.GetAllStudentList();
            //ViewBag.Students = students;
            return View(students);
        }
    }
}
