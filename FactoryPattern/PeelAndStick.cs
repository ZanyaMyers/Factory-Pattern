using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PeelAndStick : IWallDecor
    {
        public bool IsSticky { get; set; } = true;
        public bool IsExpensive { get; set; } = false;
        public bool IsEasy { get; set; } = true;

        void IWallDecor.ChooseWallDecor()
        {
            Console.WriteLine("Peel and sticks are one of the easiest ways to decorate your room without breaking a sweat");
        }
    }
}

