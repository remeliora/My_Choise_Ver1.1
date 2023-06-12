using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using MC_VER3.Classes;
using MC_VER3.Utilities;

namespace MC_VER3.ViewModel
{
    class TasksVM : ViewModelBase
    {
        public ObservableCollection<TasksClass> ListTasks { get; set; }

        public ICollectionView TasksCollectionView { get; }

        private TasksClass selectedTask;
        public TasksClass SelectedTask
        {
            get { return selectedTask; }
            set { selectedTask = value; OnPropertyChanged(); }
        }

        private string taskFilter = string.Empty;
        public string TaskFilter
        {
            get { return taskFilter; }
            set
            {
                taskFilter = value;
                OnPropertyChanged();
                TasksCollectionView.Refresh();
            }
        }

        public TasksVM()
        {
            ListTasks = new ObservableCollection<TasksClass>();

            string fileName = "Tasks.xml";
            ListTasks = XMLClass.LoadInfoTasks(fileName);

            TasksCollectionView = CollectionViewSource.GetDefaultView(ListTasks);
            TasksCollectionView.Filter = FilterTasks;

            AddTask = new RelayCommand(o =>
            {
                TasksClass newTask = new TasksClass();
                newTask.Task = "Новая задача";
                newTask.SubTask = "Описание";
                ListTasks.Add(newTask);
                XMLClass.SaveInfoTasks(ListTasks, fileName);
                SelectedTask = ListTasks[ListTasks.Count - 1];
            });

            RemoveTask = new RelayCommand(o =>
            {
                if (SelectedTask != null)
                {
                    ListTasks.Remove(SelectedTask);
                    XMLClass.SaveInfoTasks(ListTasks, fileName);
                }
            });

            RemoveAllList = new RelayCommand(o =>
            {
                if (ListTasks.Count != 0)
                {
                    ListTasks.Clear();
                    XMLClass.SaveInfoTasks(ListTasks, fileName);
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
                XMLClass.SaveInfoTasks(ListTasks, fileName);
            });
        }

        private bool FilterTasks(object obj)
        {
            if (obj is TasksClass tasksViewModel)
            {
                return tasksViewModel.Task.ToUpper().Contains(TaskFilter.ToUpper()) ||
                       tasksViewModel.SubTask.ToUpper().Contains(TaskFilter.ToUpper());
            }
            return false;
        }

        public RelayCommand AddTask { get; set; }
        public RelayCommand RemoveTask { get; set; }
        public RelayCommand RemoveAllList { get; set; }
        public RelayCommand SaveList { get; set; }
    }
}
