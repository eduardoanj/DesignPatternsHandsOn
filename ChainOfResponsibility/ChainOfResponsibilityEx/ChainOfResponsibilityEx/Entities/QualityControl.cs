using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibilityEx.Enums;
using ChainOfResponsibilityEx.Services;

namespace ChainOfResponsibilityEx.Entities
{
    class QualityControl : ServiceHandler
    {
        public QualityControl() : base(ServiceRequirements.TestDrive) { }
    }
}
