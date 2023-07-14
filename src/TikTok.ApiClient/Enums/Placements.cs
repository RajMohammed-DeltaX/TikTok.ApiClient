﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TikTok.ApiClient.Enums
{
    /// <summary>
    /// Placements enum
    /// </summary>
    public enum Placements
    {
        /// <summary>
        /// The placement topbuzz
        /// </summary>
        PLACEMENT_TOPBUZZ,

        /// <summary>
        /// The placement vigo
        /// </summary>
        [Obsolete]
        PLACEMENT_VIGO,

        /// <summary>
        /// The placement tiktok
        /// </summary>
        PLACEMENT_TIKTOK,

        /// <summary>
        /// The placement helo
        /// </summary>
        PLACEMENT_HELO,

        /// <summary>
        /// The placement pangle
        /// </summary>
        PLACEMENT_PANGLE,

        /// <summary>
        /// The placement global application bundle (Global App Bundle, including Capcut and Fizzo for now.)
        /// </summary>
        PLACEMENT_GLOBAL_APP_BUNDLE
    }
}
