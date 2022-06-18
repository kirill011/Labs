using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTest
{
    public enum Material
    {
        StainlessSteel,
        Aluminum,
        ReinforcedConcrete,
        Composite,
        Titanium
    }
    public enum CrossSelection
    {
        IBeam,
        Box,
        ZShaped,
        CShaped
    }
    public enum TestResult
    {
        Pass,
        Fail
    }
}
