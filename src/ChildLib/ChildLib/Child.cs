using System;
using System.Reflection;
using GrandChildLib;

namespace ChildLib
{
    public class Child
    {
        private GrandChild grand;

        public Child()
        {
            grand = new GrandChild();
        }

        public void Call()
        {
            Console.WriteLine($"Child.Call(){Assembly.GetExecutingAssembly().GetName().Version}");

            grand.Call();
        }
    }
}
