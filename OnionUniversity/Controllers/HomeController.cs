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
        private readonly IStudentRepository _studRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly ICourseRepository _courseRepository;
        private readonly Task6Context _db;

        public HomeController(IStudentRepository studentRepository, IGroupRepository groupRepository, ICourseRepository courseRepository)
        {
            _studRepository = studentRepository;
            _groupRepository = groupRepository;
            _courseRepository = courseRepository;
            _db = new Task6Context();
        }

        public IActionResult Index()
        {
            var courses = _courseRepository.GetAllCourseList();
            return View(courses);
        }

        public IActionResult GetStudentsList()
        {
            var students = _studRepository.GetAllStudentList();
            return View(students);
        }

        [HttpGet]
        public IActionResult GetStudentsByGroup(int groupId)
        {
            var students = _studRepository.GetStudentsByGroup(groupId);
            return View(students);
        }

        [HttpGet]
        public IActionResult GetGroupsByCourseId(int courseId)
        {
            var groups = _courseRepository.GetGroupsByCourseId(courseId).ToArray();
            return View(groups);
        }
    }
}
