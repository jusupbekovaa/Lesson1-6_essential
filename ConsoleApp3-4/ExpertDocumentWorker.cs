using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_4
{
    class ExpertDocumentWorker: ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
        public ExpertDocumentWorker() { }
        public ExpertDocumentWorker(string name):base(name)
        {

        }
        
    }
}
