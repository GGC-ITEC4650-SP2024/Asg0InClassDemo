using System;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello World!" + i);
        }

        //float x = 4.5f;
        //Console.WriteLine(f + " some stuff");

        Random rgen = new Random();

        for (int i = 0; i < 150; i++)
        {
            int r = rgen.Next(1, 5);
            Console.WriteLine("Loop: " + i + " r is " + r);
        }

        int flip = rgen.Next(0, 2);
        if (flip == 0)
        {
            Console.WriteLine("cat");
        }
        else {
            Console.WriteLine("dog");
        }

        Fruit f = new Fruit("Pear", 1.05);
        Console.WriteLine(f);

        Point p = new Point(2, 3);
        Console.WriteLine(p);

        Point p2 = new Point(5, 10);
        Point p3 = p.add(p2);

        Console.WriteLine("P3 is " + p3);

        String[,] grid = new String[5, 5];
        for(int y = 0; y < 5; y++) {
            for(int x = 0; x < 5; x ++) {
                grid[x, y] = ".";
            }
        }
        grid[2, 3] = "G";

        for(int y = 0; y < 5; y++) {
            for(int x = 0; x < 5; x ++) {
                Console.Write(grid[x, y] + " ");
            }
            Console.WriteLine();
        }


    }
}
