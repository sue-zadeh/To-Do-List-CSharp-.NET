using System.Collections.Generic;
using System.Linq;
using ToDoListApp.Models;

namespace ToDoListApp.Services
{
    public class ToDoService
    {
        private List<ToDoItem> _toDoItems = new List<ToDoItem>();

        public List<ToDoItem> GetToDoItems()
        {
            return _toDoItems;
        }

        public void AddToDoItem(ToDoItem item)
        {
            _toDoItems.Add(item);
        }

        public void RemoveToDoItem(int id)
        {
            var item = _toDoItems.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _toDoItems.Remove(item);
            }
        }
    }
}
