﻿using System;

namespace Logging
{
    public interface ILogger
    {
        void AddProperty(object key, object value);
        void Log(LogLevels level, string message, Exception exception, object parameter);
    }
}