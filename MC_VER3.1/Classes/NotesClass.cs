using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_VER3.Classes
{
    public class NotesClass : Utilities.ViewModelBase
    {
        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; OnPropertyChanged(); }
        }
    }
}
