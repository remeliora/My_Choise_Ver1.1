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
    class NotesVM : Utilities.ViewModelBase
    {
        public ObservableCollection<NotesClass> ListNotes { get; set; }

        public ICollectionView NotesCollectionView { get; }

        private NotesClass selectedNote;
        public NotesClass SelectedNote
        {
            get { return selectedNote; }
            set { selectedNote = value; OnPropertyChanged(); }
        }

        private string notesFilter = string.Empty;
        public string NotesFilter
        {
            get { return notesFilter; }
            set
            {
                notesFilter = value;
                OnPropertyChanged();
                NotesCollectionView.Refresh();
            }
        }

        public NotesVM()
        {
            ListNotes = new ObservableCollection<NotesClass>();

            string fileName = "Notes.xml";
            ListNotes = XMLClass.LoadInfoNotes(fileName);

            NotesCollectionView = CollectionViewSource.GetDefaultView(ListNotes);
            NotesCollectionView.Filter = FilterNotes;

            AddNote = new RelayCommand(o =>
            {
                NotesClass newNote = new NotesClass();
                newNote.Note = "Новая заметка";
                ListNotes.Add(newNote);
                XMLClass.SaveInfoNotes(ListNotes, fileName);
                SelectedNote = ListNotes[ListNotes.Count - 1];
            });

            RemoveNote = new RelayCommand(o =>
            {
                if (SelectedNote != null)
                {
                    ListNotes.Remove(SelectedNote);
                    XMLClass.SaveInfoNotes(ListNotes, fileName);
                }
            });

            RemoveAllList = new RelayCommand(o =>
            {
                if (ListNotes.Count != 0)
                {
                    ListNotes.Clear();
                    XMLClass.SaveInfoNotes(ListNotes, fileName);
                }
            });

            SaveList = new RelayCommand(o =>
            {
                for (int i = 0; i < ListNotes.Count; i++)
                {
                    if (ListNotes[i].Note == "")
                    {
                        ListNotes.Remove(ListNotes[i]);
                    }
                }
                XMLClass.SaveInfoNotes(ListNotes, fileName);
            });
        }

        private bool FilterNotes(object obj)
        {
            if (obj is NotesClass notesViewModel)
            {
                return notesViewModel.Note.ToUpper().Contains(NotesFilter.ToUpper());
            }
            return false;
        }

        public RelayCommand AddNote { get; set; }
        public RelayCommand RemoveNote { get; set; }
        public RelayCommand RemoveAllList { get; set; }
        public RelayCommand SaveList { get; set; }
    }
}
