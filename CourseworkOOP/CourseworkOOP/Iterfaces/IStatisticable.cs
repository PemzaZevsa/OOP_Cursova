using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseworkOOP.Entities;

namespace CourseworkOOP.Iterfaces
{
    internal interface IStatisticable
    {
        void WatchStatistics(Settings settings);
        event Action<Settings> Statistics;
    }
}
