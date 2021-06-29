using Xunit;
using FluentAssertions;
using System;
using System.Threading;
using System.Collections.Generic;   

namespace WebProject.Tests.Csharp9
{
    /*****************************************************************************************************************************************
    A Suitable example of the use Mutex is a technique that allows only one Application to run on a machine.
    When the first process acquires the mutex first, other process cannot acquires the mutext so only one process run     
    ******************************************************************************************************************************************/    

    /// <summary>
    /// Mutex Tests Class
    /// </summary>
    public static class MutexTests
    {
        /// <summary>
        /// Check Is mutext locking right
        /// </summary>
        [Fact]
        public static void IsMutexLockingThread()
        {
            Thread thread1 = new Thread(() => TestClass.AddList(10));
            Thread thread2 = new Thread(() => TestClass.AddList(20));
            
            // Execute Threads
            thread1.Start();
            thread2.Start();

            // Wait for 2 Threads are done
            thread1.Join();
            thread2.Join();

            using(Mutex mutex = new Mutex(false, "Mutex"))
            {
                TestClass.MyList.Should().HaveCount(2);

                // Wait for getting mustex for 10 ms
                if(mutex.WaitOne(10))
                {
                    // Use MyList after got mutex
                    TestClass.MyList.Add(30);
                    TestClass.MyList.Should().HaveCount(3);
                }
                else
                {
                    System.Console.WriteLine("Cannot acquire mutext");
                    TestClass.MyList.Should().HaveCount(2);
                }
            }
        }
    }


    /// <summary>
    /// For Test
    /// </summary>
    public class TestClass
    {
        /// <summary>
        /// 
        /// </summary>
        private static Mutex mtx = new Mutex(false, "MutexName1");

        /// <summary>
        /// 
        /// </summary>
        public static List<int> MyList = new List<int>(); 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static void AddList(int val)
        {
            mtx.WaitOne();
            MyList.Add(val);         
            mtx.ReleaseMutex();
        }
    }
}