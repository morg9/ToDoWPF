using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace ToDoApplication.Models
{
    public class Task
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public bool ToDelete { get; set; }

        public override string ToString() => $"{Title} {Description} {StartDate:d} {EndDate:d} {(Status ? "Completed" : "Incomplete")}";

        public Task()
        {

        }
    }
}
