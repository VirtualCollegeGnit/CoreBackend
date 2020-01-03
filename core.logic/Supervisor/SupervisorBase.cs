using core.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.logic.Supervisor
{
    public abstract class SupervisorBase
    {
        protected internal readonly VirtualCollegeContext context;

        protected SupervisorBase(VirtualCollegeContext context)
        {
            this.context = context;
        }
    }
}
