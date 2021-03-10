using System.Collections.Generic;
using UnityEngine;

namespace WispExtensions
{
    public static class WispFloat
    {
        public static float GetPercentage(this float ParamMe, float ParamPercentage)
        {
            return ParamMe * (ParamPercentage / 100);
        }

        public static float ChangeByPercentage(this float ParamMe, float ParamPercentage)
        {
            return ParamMe + (ParamMe * (ParamPercentage / 100));
        }

        public static Vector2 ToVector2(this float ParamMe)
        {
            return new Vector2(ParamMe, ParamMe);
        }
    }
}