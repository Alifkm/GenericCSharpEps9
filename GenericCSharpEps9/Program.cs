namespace GenericCSharpEps9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IRepository<T>
    {
        public void Add(T item);
        public void Remove(T item);
    }

    public class Product
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }

     public class ProductRepository : IRepository<Product>
    {
        public void Add(Product item)
        {

        }

        public void Remove(Product item)
        {

        }
    }
}