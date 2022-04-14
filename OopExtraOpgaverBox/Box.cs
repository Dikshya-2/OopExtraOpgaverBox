using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExtraOpgaverBox
{
    enum BoxType
    {
        lilleBox,
        mellemBox,
        storbox,
    };
    class Box : IComparable<Box>
    {
        public double Højde { get; set; }
        public double Bredde { get; set; }
        public double Længde { get; set; }
        public BoxType BoxTypeT { get; set; }
        public double Volume { get; set; }

        public Box()
        {

        }

        public Box(double højde, double bredde, double længde, BoxType boxtype)
        {
           Højde = højde;
           Bredde =bredde  ;
           Længde= længde;
           BoxTypeT = boxtype;

        }

        public override string ToString() // (string lilleBoxNavn, string mellemBoxNavn, string storboxNavn)

        {
            return BoxTypeT.ToString();

        }

        public int CompareTo(Box other)
        {
            throw new NotImplementedException();
            
        }

        public static Box operator +(Box b1, Box b2)
        {
            Box resBox = new Box();
            if (b1.BoxTypeT == BoxType.lilleBox && b2.BoxTypeT == BoxType.lilleBox)
                resBox.BoxTypeT = BoxType.mellemBox;
            else
                resBox.BoxTypeT = BoxType.storbox;


            resBox.Længde = b1.Længde + b2.Længde;
            resBox.Bredde = b1.Bredde + b2.Bredde;
            resBox.Højde = b1.Højde + b2.Højde;
            return resBox;
        }
        public double volume()
        {
             Volume = Længde * Bredde * Højde;
            return Volume;
        }
        public int compareTo(Box other)
        {
            return this.volume().CompareTo(other.volume());
        }
    }
}
