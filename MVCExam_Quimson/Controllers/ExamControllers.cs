using Microsoft.AspNetCore.Mvc;
using MVCExam_Quimson.Data;

namespace MVCExam_Quimson.Controllers
{
    public class ExamController : Controller
    {
        private readonly QuestionRepository _repository = new();

        public IActionResult Index()
        {
            var questions = _repository.GetAll();
            return View(questions);
        }
    }
}