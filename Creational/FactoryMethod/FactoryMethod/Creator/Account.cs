using FactoryMethod.Entities;
using System.Collections.Generic;

namespace FactoryMethod.Creator
{
    public abstract class Account
    {
        private List<Document> documents = new List<Document>();

        public Account()
        {
            CreateDocuments();
        }

        public abstract void CreateDocuments();

        public abstract void DisplayDocuments();

        public List<Document> Documents
        {
            get { return documents; }
            set { this.documents = value; }
        }
    }
}
