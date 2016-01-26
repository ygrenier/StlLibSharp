﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StlTools
{
    class Program
    {
        static string progname;
        static ProgramArgs pArgs = new ProgramArgs();

        /// <summary>
        /// Parse the command line arguments
        /// </summary>
        static void ParseArgs(string[] args)
        {
            if (args == null || args.Length == 0) return;
        }

        /// <summary>
        /// Print the header
        /// </summary>
        static void PrintHeader()
        {
            var asm = typeof(Program).Assembly;
            var asmName = asm.GetName();
            var cAttr = asm.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false).Cast<AssemblyCopyrightAttribute>().First();
            Console.WriteLine("stl-tools version {0}, {1}", asmName.Version, cAttr.Copyright);
            Console.WriteLine();
        }

        [Conditional("DEBUG")]
        static void PressKeyToQuit()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine();
                Console.WriteLine("Press a key to quit...");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            progname = Environment.GetCommandLineArgs()[0];

            ParseArgs(args);

            PrintHeader();

            PressKeyToQuit();
        }
    }
}
