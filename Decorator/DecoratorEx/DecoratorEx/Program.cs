using System;
using System.Collections.Generic;
using DecoratorEx.Interfaces;
using DecoratorEx.Mensagens;

namespace DecoratorEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<IMensagem>
            {
                new NormalDecorator(new SimpleMessage("First Message!")), 
                new NormalDecorator(new AlertMessage("Second Message with a beep!")), 
                new ErrorDecorator(new AlertMessage("Third Message with a beep and in red!")), 
                new SimpleMessage("Not Decorated...")
            }; 
            
            foreach (var message in messages)
            {
                message.PrintMensagem();
            }
            Console.Read();
        }
    }
}
