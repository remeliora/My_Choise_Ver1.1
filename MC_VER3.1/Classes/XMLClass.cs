using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace MC_VER3.Classes
{
    static class XMLClass
    {
        public static void SaveInfoTasks(ObservableCollection<TasksClass> list, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<TasksClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(fs, list);
            }
        }

        public static ObservableCollection<TasksClass> LoadInfoTasks(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<TasksClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                ObservableCollection<TasksClass> returnList = new ObservableCollection<TasksClass>();
                returnList = (ObservableCollection<TasksClass>)xml.Deserialize(fs);
                return returnList;
            }
        }

        public static void SaveInfoImpTasks(ObservableCollection<TasksImportantClass> list, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<TasksImportantClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(fs, list);
            }
        }

        public static ObservableCollection<TasksImportantClass> LoadInfoImpTasks(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<TasksImportantClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                ObservableCollection<TasksImportantClass> returnList = new ObservableCollection<TasksImportantClass>();
                returnList = (ObservableCollection<TasksImportantClass>)xml.Deserialize(fs);
                return returnList;
            }
        }

        public static void SaveInfoNotes(ObservableCollection<NotesClass> list, string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<NotesClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xml.Serialize(fs, list);
            }
        }

        public static ObservableCollection<NotesClass> LoadInfoNotes(string fileName)
        {
            XmlSerializer xml = new XmlSerializer(typeof(ObservableCollection<NotesClass>));

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                ObservableCollection<NotesClass> returnList = new ObservableCollection<NotesClass>();
                returnList = (ObservableCollection<NotesClass>)xml.Deserialize(fs);
                return returnList;
            }
        }
    }
}
