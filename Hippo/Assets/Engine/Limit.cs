using System;
using UnityEngine;

namespace Engine
{
    public class Limit
    {
        public static void ByFrames(int frames, Action action)
        {
            if (Time.frameCount % frames == 0 && action != null) action();
        }
    }
}
