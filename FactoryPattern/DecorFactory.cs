using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class DecorFactory
    {
        public static IWallDecor GetWallDecor(string userInput)
        {
            switch (userInput)
            {
                case "paint":
                    return new Paint();

                case "peel and stick":
                    return new PeelAndStick();

                case "picture frames":
                    return new PictureFrames();

                default: 
                    return new Paint();

            }
        }


       

    }
}