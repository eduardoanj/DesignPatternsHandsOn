using System;
using System.Collections.Generic;
using System.Text;

namespace estudosCSharp.Entities
{
    public class Galinha : Ave<Galinha>
    {
        public string Cor { get; set; }
    }
}
