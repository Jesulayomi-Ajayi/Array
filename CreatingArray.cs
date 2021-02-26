using System;

namespace Array
{
    class CreatingArray
    {
        static void Main(string[] args)
        {
            int[] c = new int[12];

            c[2] = 4;
            c[9] = 12;
            

            for (int i = 0; i < c.Length; ++i)
                Console.WriteLine(c[i]);

            // Console.WriteLine( "{0}{1,8}", "Index", "Value" ); // headings
            // //output each array element's value
            // for ( int i = 0; i < c.Length; ++i  )
            //     Console.WriteLine( "{0,5} {1,8}", i, c[i] );
        }
    }
}
