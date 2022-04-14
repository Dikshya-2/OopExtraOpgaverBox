using System;

namespace OopExtraOpgaverBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Opret i Main flere objekter af Box klassen,
            //  vis brugen af begge constructors, alle properties – læg 2 boxe sammen og udskriv alle objekterne vha. ToString()//
            Box b1 = new Box(5, 5, 5, BoxType.lilleBox);
            Box b2 = new Box(10, 10, 10, BoxType.mellemBox);
             

            Box resBox = new Box();
            resBox = b1 + b2;

            Console.WriteLine (b1.ToString ());
            Console.WriteLine (b2.ToString());
            Console.WriteLine(resBox.ToString());
        }
    }
}
