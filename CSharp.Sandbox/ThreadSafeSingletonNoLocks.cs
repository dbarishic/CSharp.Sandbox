using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Sandbox
{
    public sealed class ThreadSafeSingletonNoLocks
    {
        private static readonly ThreadSafeSingletonNoLocks instance = new ThreadSafeSingletonNoLocks();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit

        //If marked BeforeFieldInit then the type's initializer method is executed at, or sometime before, first access to any static field defined for that type

        //If not marked BeforeFieldInit then that type's initializer method is executed at (i.e., is triggered by):
            //1. first access to any static or instance field of that type, or
            //2. first invocation of any static, instance or virtual method of that type

        static ThreadSafeSingletonNoLocks()
        {
        }

        private ThreadSafeSingletonNoLocks()
        {
        }

        public static ThreadSafeSingletonNoLocks Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
