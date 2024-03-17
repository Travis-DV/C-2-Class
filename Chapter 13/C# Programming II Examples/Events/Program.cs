namespace Events
{
    class Program
    {
        public static void Main()
        {
            Process proc = new();
            proc.Done += proc_Done; // register with an event
            
            //Start the event:
            proc.StartProcess();
            //proc_Done will get called once it's completed.
        }

        // event handler
        public static void proc_Done()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}