/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) 2017-2018 Swan & The Quaver Team <support@quavergame.com>.
*/

using System;
using Quaver.API.Enums;

namespace Quaver.API.Helpers
{
    public static class ModeHelper
    {
        /// <summary>
        ///     Converts game mode to short hand version.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="hasScratch"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ToShortHand(GameMode mode, bool hasScratch = false)
        {
            return $"{(int)mode}K" + (hasScratch ? "+1" : "");
        }

        /// <summary>
        ///     Converts the game mode into the long hand version
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ToLongHand(GameMode mode)
        {
            return $"{(int)mode} Keys";
        }
    }
}
