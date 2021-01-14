using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorEx.Mensagens
{
    class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message)
        {
        }

        public override void PrintMensagem()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _message.PrintMensagem();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
