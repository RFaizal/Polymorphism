using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class PrinterWindows
    {
        public string printer { get; set; }

        public virtual void Show()
        {
            Console.WriteLine();
        }

        public virtual void Print()
        {
            Console.WriteLine();
        }
    }
}
