using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace JavaQuiter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                foreach (var arg in args)
                    KillProcess(arg);
                MessageBox.Show("Closed processes: " + args);
            }
            else
            {
                KillProcess("javaw");
                KillProcess("java");
                MessageBox.Show("Java processes closed.");
            }
        }

        private static void KillProcess(string pName)
        {
            Console.WriteLine("Quitting processes by the name of " + pName);
            try
            {
                foreach (var proc in Process.GetProcessesByName(pName))
                    proc.Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
