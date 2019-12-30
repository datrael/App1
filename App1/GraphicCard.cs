using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public enum CardType
    { 
    Regular,
    New
    }
    class GraphicCard
    {
        CardType catr = CardType.Regular;
        CardType catn = CardType.New;
    }
}
