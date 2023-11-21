using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PictureFrames : IWallDecor
    {
        public bool IsExpensive { get; set; }
        public bool IsEasy { get; set; }
        
        public int NumberOfPictures { get; set; }


        void IWallDecor.ChooseWallDecor()
        {
            Console.WriteLine("We have multiple frames of different designs and sizes. We also have printing services.");
        }



    }
}
