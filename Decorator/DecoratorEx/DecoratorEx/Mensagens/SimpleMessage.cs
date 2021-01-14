using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorEx.Mensagens
{
    class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text)
        {
        }

        public override void PrintMensagem()
        {
            Console.WriteLine(_text);
        }
    }
}
