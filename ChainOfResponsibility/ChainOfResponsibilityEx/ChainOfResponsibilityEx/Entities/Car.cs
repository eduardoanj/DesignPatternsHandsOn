using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityEx.Enums;

namespace ChainOfResponsibilityEx.Entities
{
    class Car
    {
        public ServiceRequirements Requirements { get; set; }

        public bool IsServiceComplete
        {
            get
            {
                return Requirements == ServiceRequirements.None;
            }
        }
    }
}
