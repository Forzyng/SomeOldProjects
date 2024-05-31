// See https://aka.ms/new-console-template for more information

int size = 100;

var arrch = new ArrayChecker(size);

arrch.Run();



class ArrayChecker
{
    private int[] arr;
    private Random rand;
    public ArrayChecker(int size)
    {
        if (size < 1)
        {
            throw new ArgumentOutOfRangeException("size < 1");
        }
        arr = new int[size];
        rand = new Random();
    }
    public void fill()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(-100, 101);
            //Console.WriteLine(arr[i]);
        }
    }
    public void LinqCount()
    {
        int resP = arr.Where(x => x > 0).Count();
        int resM = arr.Where(x => x < 0).Count();
        Console.WriteLine("Min count: " + resP);
        Console.WriteLine("Max count: " + resM);
    }

    public void forCount()
    {
        int countM = 0;
        int countP = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) countM++;
            if (arr[i] > 0) countP++;
        }

        Console.WriteLine("Min count: " + countP);
        Console.WriteLine("Max count: " + countM);
    }
    public void Run()
    {
        fill();

        var watch1 = System.Diagnostics.Stopwatch.StartNew();
        LinqCount();
        watch1.Stop();
        var elapsedMs1 = watch1.Elapsed;
        Console.WriteLine("Linq: " + elapsedMs1);

        var watch2 = System.Diagnostics.Stopwatch.StartNew();
        forCount();
        watch2.Stop();
        var elapsedMs2 = watch2.Elapsed;
        Console.WriteLine("For: " + elapsedMs2);
    }
}









