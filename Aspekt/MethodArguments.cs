﻿using System;

namespace Aspekt
{
    public class MethodArguments
    {
        public String MethodName { get; internal set; }
        public Arguments Arguments { get; internal set; }
        public String FullName { get; internal set; }

        public MethodArguments(String methodName, String fullName, Arguments args)
        {
            MethodName = methodName;
            FullName = fullName;
            if (args == null)
                Arguments = Arguments.Empty;
            else
                Arguments = args;
        }
    }
}
