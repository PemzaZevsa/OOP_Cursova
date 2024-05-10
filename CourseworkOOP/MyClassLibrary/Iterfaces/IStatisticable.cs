using System;
using CourseworkOOP.Entities;

namespace CourseworkOOP.Iterfaces
{
    internal interface IStatisticable
    {
        void WatchStatistics(CoursesAppSettings settings);
        event Action<CoursesAppSettings> Statistics;
    }
}
