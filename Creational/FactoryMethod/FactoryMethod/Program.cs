using FactoryMethod.Creator;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Account corporateAccount = new CorporateAccount();
            Account personalAccount = new PersonalAccount();

            corporateAccount.DisplayDocuments();
            personalAccount.DisplayDocuments();
        }
    }
}
