using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_White
{
    // Enumerated type.
    public enum DesktopMaterial
    {
        Oak,
        Laminte,
        Pine,
        Rosewood,
        Veneer
    };

   
internal class Desk
    {
        public int width;
        public int depth;
        public int drawers;
      

        // Set the width and depth max and min constraints.
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        
    }
}
