using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    public class Person:BaseModel
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string NationalNumber { get; set; }
        public bool Sex { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Address { get; set; }
    }
}
