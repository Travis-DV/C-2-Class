using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void Notify();
    internal class Process
    {
        public event Notify? Done;  // ? means it's nullable
        //in .Net 8.0 events are treated like fields and you will get a warning about null values otherwise.

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // Write code here for something you're going to do,
            //then when it's finished, trigger an event to 
            //indicate it's done.
            Console.WriteLine("Step A");
            Console.WriteLine("Step B");
            Console.WriteLine("Step C");

            OnCompleted();
        }

        protected virtual void OnCompleted()
        {
            //if Done is not null then call delegate
            Done?.Invoke();
        }
    }
}
