namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DateTime -> Typ zmiennej, która przechowuje informajce o dacie
            //DateTime start = DateTime.Now;
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(i);
            //    // usypianie konsoli 
            //    //Thread.Sleep(1000);
            //}
            //DateTime end = DateTime.Now;
            //Console.WriteLine($"Start eksperymentu: {start}");
            //Console.WriteLine($"Koniec eksperymentu: {end}");


            // liczby podzielne przez 13 lub 17 od 0 do 5000
            //for (int i = 0; i < 5000; i++)
            //{
            //    if (i % 13 == 0 || i%17 == 0 )
            //        Console.WriteLine(i);
            //}

            // Tabliczka mnożenia i pętle zagnieżdżone 

            for(int i = 0;i <=9;i++)
            {
                for(int j = 0; j <=9;j++)
                {
                    if(i>0)
                        Console.Write(i*j + "\t");
                    else
                        Console.Write(j + "\t");
                }
                Console.WriteLine("\n");
            }     
            Console.ReadKey();


        }
    }
}