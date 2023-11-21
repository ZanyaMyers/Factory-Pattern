using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IWallDecor
    {
       public bool IsExpensive { get; set; }
        public bool IsEasy { get; set; }

        public void ChooseWallDecor();
 

    }
    
}
