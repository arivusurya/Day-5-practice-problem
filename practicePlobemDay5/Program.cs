using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace practicePlobemDay5{
    public class Program{
        public static void Main(string[] args)
        {
            DeleteArray deleteArray = new DeleteArray();
            int[] intarray = {1,2,3,5,5,7,9};
            float[] floatarray = {3.4f,1.2f,1.8f};
            char[] chararray = "Lucifer".ToArray();
            deleteArray.Deletemethodint(intarray,5);
            deleteArray.Deletemethodfloat(floatarray,1.8f);
            deleteArray.Deletemethodchar(chararray,'f');
        }
    }
}