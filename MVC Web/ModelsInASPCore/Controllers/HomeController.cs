using Microsoft.AspNetCore.Mvc;
using ModelsInASPCore.Models;
using ModelsInASPCore.Repository;
using System.Diagnostics;
using System.Text.Json;

namespace ModelsInASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository;

        public HomeController(ILogger<HomeController> logger, StudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public List<StudentModel> getAllStudents()
        {
            var students = _studentRepository.getAllStudents();

            _logger.LogInformation("All students received: {@Students}", JsonSerializer.Serialize(students));
            return (students);
        }

        public StudentModel getById(int id)
        {
            var students = _studentRepository.getStudentById(id);


            _logger.LogInformation("Student ID: {@id}, students returned: {@Students}", id, JsonSerializer.Serialize(students)); 
            return students;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(errorViewModel);
        }
    }
}