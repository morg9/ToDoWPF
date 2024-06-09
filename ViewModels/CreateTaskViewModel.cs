using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoApplication.Commands;
using ToDoApplication.Models;
using ToDoApplication.Views;
using Task = ToDoApplication.Models.Task;

namespace ToDoApplication.ViewModels
{
    public class CreateTaskViewModel
    {
        public ICommand AddTaskCommand { get; set; }
        public ICommand CancelTaskCommand { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = DateTime.Now;
        public bool Status { get; set; }
        public bool ToDelete { get; set; }

        public CreateTaskViewModel()
        {
            AddTaskCommand = new RelayCommand(AddTask, CanAddTask);
        }

        private bool CanAddTask(object obj)
        {
            return true;
        }

        private void AddTask(object obj)
        {
            TaskManager.AddTask(new Task()
            {
                Title = Title,
                Description = Description,
                StartDate = StartDate,
                EndDate = EndDate,
                Status = false,
                ToDelete = false,
    });
        }
    }
}
