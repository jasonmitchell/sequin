﻿namespace Sequin.Infrastructure
{
    using System;

    internal class EmptyCommandBodyException : Exception
    {
        public EmptyCommandBodyException(Type commandType) : base($"Body for command of type {commandType.Name} was not provided.")
        {
            CommandType = commandType;
        }

        public Type CommandType { get; }
    }
}
