using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace PrintManagementSystem_Kazakov.Classes
{
    public class Format
    {
        public int id { get; set; }
        public string format{ get; set; }
        public string description { get; set; }
        public Format(int _id, string _format, string _description) { 
            this.id = _id; this.format = _format; this.description = _description;
        }

        public static List<Format> AllFormats()
        {
            return new List<Format>
            {
                new Format(1, "A4", ""),
                new Format(2, "A3", ""),
                new Format(3, "A2", ""),
                new Format(4, "A1", "")
            };
        }
    }
}
