using System;
using System.Collections.Generic;
using System.Text;

namespace estudosCSharp.Entities
{
    public abstract class Ave<T> where T : Ave<T>
    {
        public T Pai { get; set; }
        public T Mae { get; set; }
        public T Peso { get; set; }
    }
}
