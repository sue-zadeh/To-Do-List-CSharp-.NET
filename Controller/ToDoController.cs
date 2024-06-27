using Microsoft.AspNetCore.Mvc;
using ToDoListApp.Models;
using ToDoListApp.Services;

namespace ToDoListApp.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoService _toDoService;

        public ToDoController(ToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public IActionResult Index()
        {
            var items = _toDoService.GetToDoItems();
            return View(items);
        }

        [HttpPost]
        public IActionResult Add(ToDoItem item)
        {
            _toDoService.AddToDoItem(item);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            _toDoService.RemoveToDoItem(id);
            return RedirectToAction("Index");
        }
    }
}
