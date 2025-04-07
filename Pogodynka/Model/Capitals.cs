using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogodynka.Model
{
    internal class Capitals
    {
        public string Name { get; set; }
        public Capitals(string name)
        {
            Name = name;
        }
        public Capitals() { }
        public override string ToString()
        {
            return Name.ToString();
        }
    }
    
}
