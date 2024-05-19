using InterfaceAbstractDemo.Abstract;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Entities.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
           KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,customer.FirstName.ToUpper(),customer.Lastname.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
