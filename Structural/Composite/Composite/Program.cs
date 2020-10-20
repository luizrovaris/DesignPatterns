using Composite.Hierarchy;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
			var regionalSoutheast = new RegionalAgency("Regional Southeast", "RG-SE-0001");
			regionalSoutheast.SubAgencies.Add(new LocalAgency("São Paulo - Paulista", "LC-SP-001"));
			regionalSoutheast.SubAgencies.Add(new LocalAgency("São Paulo - Faria Lima", "LC-SP-002"));
			regionalSoutheast.SubAgencies.Add(new LocalAgency("Rio de Janeiro - Leblon", "LC-RJ-003"));

			var regionalSouth = new RegionalAgency("Regional South", "RG-S-0001");
			regionalSouth.SubAgencies.Add(new LocalAgency("Florianópolis - Estreito", "LC-SC-004"));
			regionalSouth.SubAgencies.Add(new LocalAgency("Curitiba - Água Verde", "LC-PR-005"));

			var regionalNortheast = new RegionalAgency("Regional Northeast", "RG-S-0001");
			regionalNortheast.SubAgencies.Add(new LocalAgency("Salvador - Barra", "LC-BA-006"));

			var national = new NationalAgency("National", "NT-0001");
			national.SubAgencies.Add(regionalSoutheast);
			national.SubAgencies.Add(regionalSouth);
			national.SubAgencies.Add(regionalNortheast);

			national.Display();
		}
    }
}
