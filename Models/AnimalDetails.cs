using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetClinic
{
    public class AnimalDetails : User
    {
        public string id { get; set; }
        public string Names { get; set; }
        public string Owner { get; set; }
        public ushort Age { get; set; }
        public string Type { get; set; }
        public bool SickOrNot = false;
        public string Notes = "";
    }
}