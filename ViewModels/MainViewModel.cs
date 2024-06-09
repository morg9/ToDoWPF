using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using ToDoApplication.Commands;
using ToDoApplication.Models;
using ToDoApplication.Views;
using Task = ToDoApplication.Models.Task;

namespace ToDoApplication.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Task> Tasks { get; set; }
        public ICommand ShowWindowCommand { get; set; }
        public ICommand DumpTasksCommand { get; set; }
        public ICommand DeleteTaskCommand { get; set; }

        public MainViewModel()
        {
            Tasks = TaskManager.GetTasks();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
            DumpTasksCommand = new RelayCommand(DumpTasks, CanDumpTasks);
            DeleteTaskCommand = new RelayCommand(DeleteTask, CanDeleteTask);
        }

        private bool CanDeleteTask(object obj)
        {
            return true;
        }

        private void DeleteTask(object obj)
        {
            foreach (var task in Tasks.ToList())
            {
                if (task.ToDelete == true)
                {
                    TaskManager.DeleteTask(task);
                }
            }
            
        }

        private bool CanDumpTasks(object obj)
        {
            return true;
        }

        public void DumpTasks(object obj)
        {
            foreach (var task in Tasks)
            {
                Debug.WriteLine(task.ToString());
            }
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var TaskListView = obj as Window;
            CreateTaskView createTaskView = new CreateTaskView();
            createTaskView.Owner = TaskListView;
            createTaskView.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            createTaskView.Show();
        }
    }
}
