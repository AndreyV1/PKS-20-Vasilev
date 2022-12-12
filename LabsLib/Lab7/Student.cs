using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AllLabsProject
{
    [DataContract]
    public class Student : Person
    {
        [DataMember]
        public string Group { get; set; }
        [DataMember]
        public string Institution { get; set; }
        [DataMember]
        public string Specialization { get; set; }

    }
}
