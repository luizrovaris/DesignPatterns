using FactoryMethod.Entities;
using System;

namespace FactoryMethod.Creator
{
    public class CorporateAccount : Account
    {
        public override void CreateDocuments()
        {
            base.Documents.Add(new CertificateOfIncorporation());
        }

        public override void DisplayDocuments()
        {
            Console.WriteLine("Corporate Account Documents: ");
            foreach (Document document in base.Documents)
            {
                Console.WriteLine(document.Name);
            }
        }
    }
}
