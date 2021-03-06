﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Microsoft Corporation">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// </copyright>
// <summary>
//   The constants.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Sample.AudioVideoPlaybackBot.FrontEnd
{
    using System.Collections.Generic;
    using Microsoft.Skype.Bots.Media;

    /// <summary>
    /// Contants used by the bot.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Number of sockets to receive video only
        /// The main video socket being sendrecv this brings the total to NumberOfMultivewSockets + 1 receive channels.
        /// </summary>
        public const uint NumberOfMultivewSockets = 3;

        /// <summary>
        /// Stores a list of supported video formats.
        /// </summary>
        public static readonly List<VideoFormat> SupportedSendVideoFormats = new List<VideoFormat>
        {
            VideoFormat.H264_1280x720_30Fps,
            VideoFormat.H264_640x360_30Fps,
            VideoFormat.H264_320x180_15Fps,
        };
    }
}
