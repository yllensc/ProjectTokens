using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Entities;
    public class Client: BaseEntity
    {
        public int IdentificationNumber { get; set;}
        public string Name { get; set; }
        public string Email { get; set;}
        public int PhoneNumber { get; set;}
    
    }
