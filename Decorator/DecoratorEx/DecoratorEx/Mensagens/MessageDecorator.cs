using System;
using System.Collections.Generic;
using System.Text;
using DecoratorEx.Interfaces;

namespace DecoratorEx.Mensagens
{
    abstract class MessageDecorator : IMensagem
    {
        protected Message _message;

        public MessageDecorator(Message message)
        {
            _message = message;
        }

        public abstract void PrintMensagem();
    }
}
