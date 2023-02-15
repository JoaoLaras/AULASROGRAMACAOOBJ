﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Herançamúltiplaeoproblemadodiamante.Devices
{
    internal class Printer : Device , IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);

        }
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document); 
        }
    }
}
