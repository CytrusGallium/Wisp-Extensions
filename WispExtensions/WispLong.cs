using System;
using System.Collections.Generic;
using UnityEngine;

namespace WispExtensions
{
    public static class WispLong
    {
        public static long GetPercentage(this long ParamMe, float ParamPercentage)
        {
            return Convert.ToInt64(ParamMe * (ParamPercentage / 100));
        }

        public static long ChangeByPercentage(this long ParamMe, float ParamPercentage)
        {
            return ParamMe + Convert.ToInt64((ParamMe * (ParamPercentage / 100)));
        }

        public static Vector2 ToVector2(this long ParamMe)
        {
            return new Vector2(ParamMe, ParamMe);
        }

        public static long Clamp(this long ParamMe, long ParamMin, long ParamMax)
        {
            if (ParamMe < ParamMin) { return ParamMin; }
            if (ParamMe > ParamMax) { return ParamMax; }
            return ParamMe;
        }
    }
}