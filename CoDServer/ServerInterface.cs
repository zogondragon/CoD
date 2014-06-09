﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDServer
{
    // It controls information flow between (CoDServer) and (CoDClient).
    // It is abstract class because the interface can be anything including TCP, UDP, Pipe and Txt.
    public abstract class ServerInterface
    {
        public abstract string ReadLine();
        public abstract void WriteLine();
    }

    // For example, it gets input from localhost:63999
    public class TCPServerInterface : ServerInterface
    {
        // TODO: implement this
        public override string ReadLine()
        {
            return Console.ReadLine();
        }

        public override void WriteLine()
        {
            Console.WriteLine();
        }
    }

    // Gets command from console, return the result to stdout
    public class ConsoleServerInterface : ServerInterface
    {
        public override string ReadLine()
        {
            return Console.ReadLine();
        }

        public override void WriteLine()
        {
            Console.WriteLine();
        }
    }
}
