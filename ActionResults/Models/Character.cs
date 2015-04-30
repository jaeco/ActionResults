using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ActionResults.Models
{
    //[DataContract]
    public class Character
    {
        //[DataMember]
        public string Name { get; set; }
       // [DataMember]
        public int Level { get; set; }
       // [DataMember]
        public int HealthPoints { get; set; }
       // [DataMember]
        public Dictionary<string, Int32> Attributes = new Dictionary<string, Int32>() {
        {"IQ", 8},{"ME", 9},{"MA", 12},{"PS", 3},{"PP", 4},{"PE", 8},{"PB", 7},{"Spd", 6}};

        public override string ToString()
        {
            string temp = "";
            foreach (KeyValuePair<string, Int32> attribute in Attributes)
            {
                temp += " "+attribute.Key+": "+attribute.Value;
            }

            return "Name: " + Name + "// Level: " + Level + "// HP: " + HealthPoints + "//" + temp;
        }
    }
}