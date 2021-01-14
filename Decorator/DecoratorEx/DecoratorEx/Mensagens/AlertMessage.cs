using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorEx.Mensagens
{
    class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text)
        {
        }

        public override void PrintMensagem()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
}
