using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_VER3.Classes
{
    public class TasksImportantClass : Utilities.ViewModelBase
    {
        private string task;
        public string Task
        {
            get { return task; }
            set { task = value; OnPropertyChanged(); }
        }

        private string subTask;
        public string SubTask
        {
            get { return subTask; }
            set { subTask = value; OnPropertyChanged(); }
        }
    }
}
