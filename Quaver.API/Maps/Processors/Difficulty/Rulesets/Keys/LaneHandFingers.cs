using System;
using System.Collections.Generic;
using Quaver.API.Enums;
using Quaver.API.Maps.Processors.Difficulty.Rulesets.Keys.Structures;

namespace Quaver.API.Maps.Processors.Difficulty.Rulesets.Keys
{
    public static class LaneHandFingers
    {
        public static Hand LaneToHand(GameMode mode, int lane)
        {
            if (lane > (int)mode)
                throw new ArgumentOutOfRangeException();

            if ((int)mode % 2 == 0)
            {
                if (lane <= (int)mode / 2)
                    return Hand.Left;
                else
                    return Hand.Right;
            }

            if (lane <= (int)mode / 2)
                return Hand.Left;
            else if (lane == (int)mode / 2 + 1)
                return Hand.Ambiguous;
            else
                return Hand.Right;
        }

        public static FingerState LaneToFingerState(GameMode mode, int lane)
        {
            if (lane > (int)mode)
                throw new ArgumentOutOfRangeException();

            var half = (int)mode / 2;

            if ((int)mode <= 9)
            {
                if ((int)mode % 2 == 0)
                {
                    if (lane <= half)
                        return (FingerState)(1 << (half - (lane - 1)));
                    else
                        return (FingerState)(1 << (half + (lane - half - 1)));
                }

                if (lane <= half)
                    return (FingerState)(1 << (half - (lane - 1)));
                else if (lane == half + 1)
                    return FingerState.Thumb;
                else
                    return (FingerState)(1 << (half + (lane - half - 1)));
            }

            return FingerState.None;
        }
    }
}