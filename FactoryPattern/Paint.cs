using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Paint : IWallDecor
    {
        public bool IsExpensive { get; set; }
        public int NumberOfCans { get; set; }
        bool IWallDecor.IsEasy { get; set; }

        void IWallDecor.ChooseWallDecor()
        {
            Console.WriteLine("We have premixed paint colors so you can have a smooth painting experience.");
        }
    }
}
