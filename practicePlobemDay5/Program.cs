using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace practicePlobemDay5{
    public class Program{
        public static void Main(string[] args)
        {
            int[] intarray = {1,2,3,5,5,7,9};
            float[] floatarray = {3.4f,1.2f,1.8f};
            char[] chararray = "Lucifer".ToArray();
            DeleteArrayGenerics <int> deleteArray = new DeleteArrayGenerics<int>(intarray);
            DeleteArrayGenerics <float> deleteArrayfloat = new DeleteArrayGenerics<float>(floatarray);
            DeleteArrayGenerics <char> deleteArraychar = new DeleteArrayGenerics<char>(chararray);
            deleteArray.DeleteElement(5);
            deleteArrayfloat.DeleteElement(1.6f);
            deleteArraychar.DeleteElement('L');


            
         
            

        }
    }
}