using Bridge.Enumerator;
using System.Collections.Generic;

namespace Bridge.DTO
{
    public class AccountDTO
    {
        public CustomerType CustomerType { get; set; }
        public List<string> MandatoryDocuments { get; set; }
    }
}
