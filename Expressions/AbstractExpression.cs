using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.Expressions
{
    public abstract class AbstractExpression
    {
        protected Output.IOutput output;
        public AbstractExpression(Output.IOutput output)
        {
            this.output = output;
        }

    }
}
