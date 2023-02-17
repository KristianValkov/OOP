namespace ConsoleApp1
{
    internal class Program
    {
        static int Fact(int n)
        {
           if (n <= 0) return 1;
           else return n*Fact(n-1);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
