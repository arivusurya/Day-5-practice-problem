namespace practicePlobemDay5
{
    public class DeleteArrayGenerics<T>
    {
        public T[] array ;

        public DeleteArrayGenerics(T[] array) {
            this.array = array;
        }  

        public void DeleteElement(T element) {
            array = Array.FindAll<T>(array, item => !item.Equals(element));
            System.Console.WriteLine(string.Join(" ",array));
        }

    }
}