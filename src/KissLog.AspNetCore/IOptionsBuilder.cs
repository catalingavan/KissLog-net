﻿using System;

namespace KissLog.AspNetCore
{
    public interface IOptionsBuilder
    {
        ListenersContainer Listeners { get; }
        Options Options { get; }
        Action<string> InternalLog { get; set; }
    }
}
