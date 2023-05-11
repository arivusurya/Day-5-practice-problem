namespace practicePlobemDay5
{
    public class DeleteArray
    {
        public void Deletemethodint(int[] array,int element){
            array = Array.FindAll(array , item => item != element);
            System.Console.WriteLine(String.Join(',',array));
        }
         public void Deletemethodfloat(float[] array,float element){
            array = Array.FindAll(array , item => item != element);
            System.Console.WriteLine(String.Join(',',array));
        }
          public void Deletemethodchar(char[] array,char element){
            array = Array.FindAll(array , item => item != element);
            System.Console.WriteLine(String.Join(',',array));
        }

        public void Deletemethodgeneric<T>(T[] array,T element){
            array = Array.FindAll(array , item => !item.Equals(element));
            System.Console.WriteLine(String.Join(',',array));
            
        }
    }
}