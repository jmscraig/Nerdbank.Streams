﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Nerdbank.Streams
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.IO.Pipelines;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft;
    using Microsoft.VisualStudio.Threading;

    /// <content>
    /// Contains the <see cref="ChannelOfferEventArgs"/> nested type.
    /// </content>
    public partial class MultiplexingStream
    {
        /// <summary>
        /// Describes an offer for a channel.
        /// </summary>
        public class ChannelOfferEventArgs : EventArgs
        {
            /// <summary>
            /// Gets the unique ID of the channel.
            /// </summary>
            public int ChannelId { get; }

            /// <summary>
            /// Gets the name of the channel.
            /// </summary>
            public string ChannelName { get; }

            /// <summary>
            /// Gets a value indicating whether the channel has already been accepted.
            /// </summary>
            public bool IsAccepted { get; }
        }
    }
}
