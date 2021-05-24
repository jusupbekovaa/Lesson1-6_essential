using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_4
{
    class DocumentWorker
    {
        string versionName;
        public string VersionName
        {
            get { return versionName; }
            set { versionName = value; }
        }
        public void OpenDocument() 
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument() 
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument() 
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
        public DocumentWorker()
        {

        }
        public DocumentWorker(string name)
        {
            this.versionName = name;
        }
    }
}
