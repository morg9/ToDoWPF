using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoApplication.Models
{
    public class TaskManager
    {
        public static ObservableCollection<Task> ListTasks = new ObservableCollection<Task>()
        {

            new Task()
            {
                Title = "Unit 16",
                Description = "Create to do list",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                Status = true,
                ToDelete = false,
            },
            new Task()
            {
                Title = "Unit 16",
                Description = "Create book sorting program",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                Status = false,
                ToDelete = false,
            }
        };

        public static ObservableCollection<Task> GetTasks()
        {
            return ListTasks;
        }

        public static void AddTask(Task task)
        {
            ListTasks.Add(task);
        }

        public static void DeleteTask(Task task)
        {
            ListTasks.Remove(task);
        }
    }
}
