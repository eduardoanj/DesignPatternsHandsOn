using System;
using System.Collections.Generic;
using System.Text;
using DecoratorEx.Interfaces;

namespace DecoratorEx.Mensagens
{
    abstract class Message : IMensagem
    {
        protected string _text;

        public Message(string text)
        {
            _text = text;
        }

        abstract public void PrintMensagem();
    }
}
