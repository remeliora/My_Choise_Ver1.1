using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MC_VER3.Classes;
using MC_VER3.Utilities;

namespace MC_VER3.ViewModel
{
    class TasksImportantVM : Utilities.ViewModelBase
    {
        public ObservableCollection<TasksImportantClass> ListTasks { get; set; }

        public ICollectionView ImportantCollectionView { get; }

        private TasksImportantClass selectedTask;
        public TasksImportantClass SelectedTask
        {
            get { return selectedTask; }
            set { selectedTask = value; OnPropertyChanged(); }
        }

        private string impTaskFilter = string.Empty;
        public string ImpTaskFilter
        {
            get { return impTaskFilter; }
            set
            {
                impTaskFilter = value;
                OnPropertyChanged();
                ImportantCollectionView.Refresh();
            }
        }

        public TasksImportantVM()
        {
            ListTasks = new ObservableCollection<TasksImportantClass>();

            string fileName = "ImportantTasks.xml";
            ListTasks = XMLClass.LoadInfoImpTasks(fileName);

            ImportantCollectionView = CollectionViewSource.GetDefaultView(ListTasks);
            ImportantCollectionView.Filter = ImpFilterTasks;

            AddTask = new RelayCommand(o =>
            {
                TasksImportantClass newTask = new TasksImportantClass();
                newTask.Task = "Новая важная задача";
                newTask.SubTask = "Описание";
                ListTasks.Add(newTask);
                XMLClass.SaveInfoImpTasks(ListTasks, fileName);
                SelectedTask = ListTasks[ListTasks.Count - 1];
            });

            RemoveTask = new RelayCommand(o =>
            {
                if (SelectedTask != null)
                {
                        ListTasks.Remove(SelectedTask);
                        XMLClass.SaveInfoImpTasks(ListTasks, fileName);
                }
            });

            RemoveAllList = new RelayCommand(o =>
            {
                if (ListTasks.Count != 0)
                {
                    ListTasks.Clear();
                    XMLClass.SaveInfoImpTasks(ListTasks, fileName);
                }
            });

            SaveList = new RelayCommand(o =>
            {
                for (int i = 0; i < ListTasks.Count; i++)
                {
                    if (ListTasks[i].Task == "" && ListTasks[i].SubTask == "")
                    {
                        ListTasks.Remove(ListTasks[i]);
                    }
                }
                XMLClass.SaveInfoImpTasks(ListTasks, fileName);
            });
        }
        private bool ImpFilterTasks(object obj)
        {
            if (obj is TasksImportantClass importantTasksVM)
            {
                return importantTasksVM.Task.ToUpper().Contains(ImpTaskFilter.ToUpper()) ||
                       importantTasksVM.SubTask.ToUpper().Contains(ImpTaskFilter.ToUpper());
            }
            return false;

        }

        public RelayCommand AddTask { get; set; }
        public RelayCommand RemoveTask { get; set; }
        public RelayCommand RemoveAllList { get; set; }
        public RelayCommand SaveList { get; set; }
    }
}
