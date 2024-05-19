using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer:IEntitiy
    {
        public int İd { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }


    }
}
