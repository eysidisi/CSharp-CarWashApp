using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEICO.CarWash.Service.Util
{
    public enum Station
    {
        Entry,
        Station1,
        Station2,
        Station3,
        Exit
    }

    public enum Wash_Step_Type
    {
        UnderBodyWash,
        BugRemover,
        PreSoak,
        HighPressureWash,
        LowPressureWax,
        SpotFreeRinse,
        TireShineFoam,
        AirDry,
        CarOutOfPosition
    };
}
