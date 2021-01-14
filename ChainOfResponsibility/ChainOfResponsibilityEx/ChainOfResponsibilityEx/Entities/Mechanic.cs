using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityEx.Enums;
using ChainOfResponsibilityEx.Services;

namespace ChainOfResponsibilityEx.Entities
{
    class Mechanic : ServiceHandler
    {
        public Mechanic() : base(ServiceRequirements.EngineTune) { }
    }
}
