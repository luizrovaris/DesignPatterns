using Prototype.Concrete;
using Prototype.Enumerator;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountMenu = new AccountMenu();

            accountMenu[AccountTypes.BigBusinessAccount] = new Account("Business Account - Prime", "Certificate of Incorporation, Balance Sheet");
            accountMenu[AccountTypes.SmallBusinessAccount] = new Account("Business Account - Basic", "Certificate of Incorporation, Balance Sheet");
            accountMenu[AccountTypes.PersonalAccount] = new Account("Personal Account", "Federal Identification, Final Payslip");
            accountMenu[AccountTypes.EmployeeAccount] = new Account("Employee Account - Basic", "Employee Contract, Leaf Discount");
            accountMenu[AccountTypes.SeniorEmployeeAccount] = new Account("Business Account - Prime", "Employee Contract, Leaf Discount");

            Account accountBusinessPrime01 = accountMenu[AccountTypes.BigBusinessAccount].Clone() as Account;
            Account accountEmployee01 = accountMenu[AccountTypes.EmployeeAccount].Clone() as Account;
            Account accountEmployee02 = accountMenu[AccountTypes.EmployeeAccount].Clone() as Account;

            accountBusinessPrime01.Display();
            accountEmployee01.Display();
            accountEmployee02.Display();

            accountBusinessPrime01.SetPersonalData("009982711", "AWS");
            accountEmployee01.SetPersonalData("023817262", "Pedro Silva");
            accountEmployee02.SetPersonalData("032234643", "Ana Costa");

            accountBusinessPrime01.Display();
            accountEmployee01.Display();
            accountEmployee02.Display();
        }
    }
}
