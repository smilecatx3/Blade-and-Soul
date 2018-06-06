using System;

namespace BladeAndSoul.EventTimeCalculator
{
    class Calculator
    {
        public static DateTime[] GetNextEventTimes(DateTime start, uint length)
        {
            DateTime[] results = new DateTime[length];

            results[0] = start.AddMinutes(60);
            for (int i = 1; i < length; i++)
            {
                results[i] = results[i-1].AddMinutes(73);
            }

            return results;
        }
    }
}
