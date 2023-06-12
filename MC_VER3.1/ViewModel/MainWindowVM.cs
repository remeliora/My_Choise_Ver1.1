using MC_VER3.Utilities;

namespace MC_VER3.ViewModel
{
    internal class MainWindowVM : Utilities.ViewModelBase
    {
        public RelayCommand ShowTasksView { get; set; }
        public RelayCommand ShowImportantView { get; set; }
        public RelayCommand ShowNotesView { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public TasksVM TVM { get; set; } = new TasksVM();
        public TasksImportantVM TIVM { get; set; } = new TasksImportantVM();
        public NotesVM NVM { get; set; } = new NotesVM();

        public MainWindowVM()
        {
            ShowTasksView = new RelayCommand(o => { CurrentView = TVM; });
            ShowImportantView = new RelayCommand(o => { CurrentView = TIVM; });
            ShowNotesView = new RelayCommand(o => { CurrentView = NVM; });

            CurrentView = TVM;
        }
    }
}
