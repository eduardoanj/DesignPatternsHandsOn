using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityEx.Enums;
using ChainOfResponsibilityEx.Services;

namespace ChainOfResponsibilityEx.Entities
{
    class Detailer : ServiceHandler
    {
        public Detailer() : base(ServiceRequirements.Dirty) { }
    }
}
