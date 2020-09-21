using FactoryMethod.Entities;
using System;

namespace FactoryMethod.Creator
{
    public class PersonalAccount : Account
    {
        public override void CreateDocuments()
        {
            base.Documents.Add(new FederalIdentification());
        }

        public override void DisplayDocuments()
        {
            Console.WriteLine("Personal Account Documents: ");
            foreach (Document document in base.Documents)
            {
                Console.WriteLine(document.Name);
            }
        }
    }
}
