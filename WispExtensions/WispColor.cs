using UnityEngine;

namespace WispExtensions
{
    public static class WispColor
    {
        public static Color ColorOpacity(this Color ParamColor, float ParamOpacity)
        {
            return new Color(ParamColor.r, ParamColor.g, ParamColor.b, ParamColor.a * ParamOpacity);
        }
    } 
}