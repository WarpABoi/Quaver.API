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
        public static string ToShortHand(GameMode mode, bool hasScratch = false) => mode switch
        {
            GameMode.Keys4 => "4K",
            GameMode.Keys7 => "7K",

            GameMode.Keys1 => "1K",
            GameMode.Keys2 => "2K",
            GameMode.Keys3 => "3K",
            GameMode.Keys5 => "5K",
            GameMode.Keys6 => "6K",
            GameMode.Keys8 => "8K",
            GameMode.Keys9 => "9K",
            GameMode.Keys10 => "10K",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
        } + (hasScratch ? "+1" : "");

        /// <summary>
        ///     Converts the game mode into the long hand version
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string ToLongHand(GameMode mode) => mode switch
        {
            GameMode.Keys4 => "4 Keys",
            GameMode.Keys7 => "7 Keys",

            GameMode.Keys1 => "1 Key",
            GameMode.Keys2 => "2 Keys",
            GameMode.Keys3 => "3 Keys",
            GameMode.Keys5 => "5 Keys",
            GameMode.Keys6 => "6 Keys",
            GameMode.Keys8 => "8 Keys",
            GameMode.Keys9 => "9 Keys",
            GameMode.Keys10 => "10 Keys",
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
        };

        public static int ToKeyCount(GameMode mode, bool hasScratch = false) => mode switch
        {
            GameMode.Keys4 => 4,
            GameMode.Keys7 => 7,

            GameMode.Keys1 => 1,
            GameMode.Keys2 => 2,
            GameMode.Keys3 => 3,
            GameMode.Keys5 => 5,
            GameMode.Keys6 => 6,
            GameMode.Keys8 => 8,
            GameMode.Keys9 => 9,
            GameMode.Keys10 => 10,
            _ => throw new ArgumentOutOfRangeException(nameof(mode), mode, null)
        } + (hasScratch ? 1 : 0);

        public static GameMode FromKeyCount(int keyCount) => keyCount switch
        {
            4 => GameMode.Keys4,
            7 => GameMode.Keys7,

            1 => GameMode.Keys1,
            2 => GameMode.Keys2,
            3 => GameMode.Keys3,
            5 => GameMode.Keys5,
            6 => GameMode.Keys6,
            8 => GameMode.Keys8,
            9 => GameMode.Keys9,
            10 => GameMode.Keys10,
            _ => throw new ArgumentOutOfRangeException(nameof(keyCount), keyCount, null)
        };

        public static bool IsKeyMode(GameMode mode) => mode switch
        {
            GameMode.Keys4 => true,
            GameMode.Keys7 => true,

            GameMode.Keys1 => true,
            GameMode.Keys2 => true,
            GameMode.Keys3 => true,
            GameMode.Keys5 => true,
            GameMode.Keys6 => true,
            GameMode.Keys8 => true,
            GameMode.Keys9 => true,
            GameMode.Keys10 => true,
            _ => false
        };
    }
}
