using System;

namespace BladeAndSoul.EventTimeCalculator
{
    class Calculator
    {
        public static DateTime[] GetNextEventTimes(DateTime start, uint length)
        {
            DateTime[] results = new DateTime[length];

            DateTime previous = start;
            for (int i=0; i<length; i++)
            {
                results[i] = previous.AddMinutes(73);
                previous = results[i];
            }

            return results;
        }
    }
}
