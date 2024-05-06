namespace work12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YaşınI gir:");
            int yas = int.Parse(Console.ReadLine());

            if (yas >= 1 && yas <= 6)
            {
                Console.WriteLine("uşaq");
            }
            else if (yas >= 7 && yas <= 17)
            {
                Console.WriteLine("şagird");
            }
            else if (yas >= 18 && yas <= 35)
            {
                Console.WriteLine("gənc");
            }
            else if (yas >= 36 && yas <= 63)
            {
                Console.WriteLine("yetkinlik");
            }
            else if (yas == 64)
            {
                Console.WriteLine("təqaüdçü");
            }
            else
            {
                Console.WriteLine("Düzgün yaş yaz.");
            }


        }
    }


}
