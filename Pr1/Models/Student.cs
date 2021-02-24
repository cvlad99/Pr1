using System;

namespace Pr1.Models
{
    public class Student : BaseEntity
    {
        public String Name { get; set; }
        public String Cnp { get; set; }
        public int Restances { get; set; }
    }
}
