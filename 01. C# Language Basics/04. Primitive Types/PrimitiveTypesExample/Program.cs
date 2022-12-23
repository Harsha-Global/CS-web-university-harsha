class Sample
{
    static void Main()
    {
        sbyte a = sbyte.MaxValue;
        sbyte b = 100;
        sbyte c = default(sbyte);

        byte d = byte.MaxValue;
        short e = short.MaxValue;
        ushort f = ushort.MaxValue;
        int g = int.MaxValue;
        uint h = uint.MaxValue;
        long i = long.MaxValue;
        ulong j = ulong.MaxValue;
        float k = float.MaxValue;
        double l = double.MaxValue;
        decimal m = decimal.MaxValue;
        char n = 'A';
        string o = "abc";
        bool p = true;

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        System.Console.WriteLine(h);
        System.Console.WriteLine(i);
        System.Console.WriteLine(j);
        System.Console.WriteLine(k);
        System.Console.WriteLine(l);
        System.Console.WriteLine(m);
        System.Console.WriteLine(n);
        System.Console.WriteLine(o);
        System.Console.WriteLine(p);

        System.Console.ReadKey();
    }
}