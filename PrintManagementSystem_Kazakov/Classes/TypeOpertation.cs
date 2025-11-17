using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Kazakov.Classes
{
    public class TypeOpertation
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public TypeOpertation(int _id, string _name, string _description) { 
            this.id = _id; this.name = _name; this.description = _description;
        }
        public static List<TypeOpertation> AllTypeOperation()
        {
            return new List<TypeOpertation>()
            {
                new TypeOpertation(1, "Печать", ""),
                new TypeOpertation(2, "Копия", ""),
                new TypeOpertation(3, "Скан", ""),
                new TypeOpertation(4, "Ризограф", "")
            };
        }
    }
}
