using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface Affiliation
    {
        double CalculateDeductions(Paycheck pc);
    }
}
