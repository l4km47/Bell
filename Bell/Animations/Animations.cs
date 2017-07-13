﻿using System;

namespace RcisSchoolBell.Animations
{
    internal enum AnimationType
    {
        Linear,
        EaseInOut,
        EaseOut,
        CustomQuadratic
    }

    internal static class AnimationLinear
    {
        public static double CalculateProgress(double progress)
        {
            return progress;
        }
    }

    internal static class AnimationEaseInOut
    {
        public static double Pi = Math.PI;
        public static double PiHalf = Math.PI / 2;

        public static double CalculateProgress(double progress)
        {
            return EaseInOut(progress);
        }

        private static double EaseInOut(double s)
        {
            return s - Math.Sin(s * 2 * Pi) / (2 * Pi);
        }
    }

    public static class AnimationEaseOut
    {
        public static double CalculateProgress(double progress)
        {
            return -1 * progress * (progress - 2);
        }
    }

    public static class AnimationCustomQuadratic
    {
        public static double CalculateProgress(double progress)
        {
            double kickoff = 0.6;
            return 1 - Math.Cos((Math.Max(progress, kickoff) - kickoff) * Math.PI / (2 - (2 * kickoff)));
        }
    }
}
