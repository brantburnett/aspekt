﻿using Aspekt;
using Aspekt.Contracts;
using Aspekt.Logging;
using System;

namespace Aspekt.Target
{
    class TargetAttribute : Aspect
    {
        public TargetAttribute(object s)
        {
        }
        public override void OnEntry(MethodArguments args)
        {
        }

        public override void OnException(MethodArguments args, Exception e)
        {
        }

        public override void OnExit(MethodArguments args)
        {
        }
    }

    class TargetClassAttribute : Aspect
    {
        public TargetClassAttribute()
        {
        }
        public override void OnEntry(MethodArguments args)
        {
        }

        public override void OnException(MethodArguments args, Exception e)
        {
        }

        public override void OnExit(MethodArguments args)
        {
        }
    }

    class TestAttribute : Aspect
    {
        public TestAttribute(object obj)
        {

        }
    } 

    [TargetClassAttribute]
    class Application
    {

        
        public void Function(int someValue)
        {
            RequiresArgumentAttribute ra = new RequiresArgumentAttribute(0, typeof(int), Contract.Comparison.LessThan, 5);
            Console.Write($"Some Value: {someValue}");
        }

        [RequiresArgument(0,typeof(int),Contract.Comparison.GreaterThan, 5)]
        public void Function2(int someValue)
        {
            Console.Write($"Some Value: {someValue}");
        }

        public static void Bar()
        {
            Console.WriteLine("Bar None");

        }
        
        public enum Choice { Yes, No}
        [Target(6)]
        public static void Test(object otter, Type tail, int indigo, Choice choice)
        {
        }
    }
}
