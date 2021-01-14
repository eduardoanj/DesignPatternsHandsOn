using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityEx.Enums
{
    [Flags]
    enum ServiceRequirements
    { 
        None = 0, 
        WheelAlignment = 1, 
        Dirty = 2, 
        EngineTune = 4, 
        TestDrive = 8
    }
}
