using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorEx.Mensagens
{
    class ErrorDecorator : MessageDecorator
    {
        public ErrorDecorator(Message message) : base(message)
        {
        }

        public override void PrintMensagem()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            _message.PrintMensagem();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
