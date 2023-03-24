// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Azure.AI.OpenAI
{
    internal class TimeConverters
    {
        internal static DateTime DateTimeFromUnixEpoch(long secondsAfterUnixEpoch)
            => DateTime.UnixEpoch.AddSeconds(secondsAfterUnixEpoch);
    }
}
