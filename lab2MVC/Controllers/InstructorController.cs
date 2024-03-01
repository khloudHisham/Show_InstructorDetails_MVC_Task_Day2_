using lab2MVC.Models;
using Microsoft.AspNetCore.Mvc;

public class InstructorController : Controller
{
    ITIContext context = new ITIContext();

    public IActionResult Index()
    {
        List<instructor> InstructorListModel = context.instructor.ToList();
        return View("Index", InstructorListModel);
    }

    public IActionResult ShowAll(int id)
    {
        var instructor = context.instructor.FirstOrDefault(i => i.Id == id);
        if (instructor == null)
        {
            return NotFound(); // or handle the case where instructor with given id is not found
        }

        return View("ShowDetails", instructor);
    }
}
