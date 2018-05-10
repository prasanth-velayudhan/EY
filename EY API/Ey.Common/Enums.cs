using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ey.Common
{
    /// <summary>
    /// Class of Enums
    /// </summary>
    [Serializable]
    public class Enums
    {
        public const int PayToChange = 1;
        public const int FreeToChange = 2;
        public const int NoChange = 3;
        public const int Business = 4;  //Added by a-5467 - Platinum changes

        public enum PassengerTypes
        {
            Adult = 1,
            Child = 6,
            Infant = 5
        }

        public enum FareBrandOrder
        {
            YB = 1, YS = 2, YV = 3, YF = 4, JB = 5, JS = 6, JF = 7, FI = 8
        }  
    }
}
