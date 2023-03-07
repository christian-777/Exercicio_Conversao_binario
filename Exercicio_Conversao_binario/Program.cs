internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i=7;
        int[] converted= new int[8];


        Console.WriteLine("digite um numero: ");
        num = int.Parse(Console.ReadLine());

        Converte(num);

        for(int j = 0; j < converted.Length; j++)
        {
            Console.Write(converted[j]);
        }


        int Converte(int x)
        {
            if (x > 0)
            {
                converted[i] = x % 2;
                int r = x / 2;
                i--;
                return Converte(r);
            }
            return 0;
        }
    }
}