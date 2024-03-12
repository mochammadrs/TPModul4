public class KodePos
{
    public enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    public static int GetKodePos(Kelurahan kelurahan)
    {
        int[] kodePosSetiapKelurahan = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        return kodePosSetiapKelurahan[(int)kelurahan];
    }

    public static void Main(string[] args)
    {
        Kelurahan lurah1 = Kelurahan.Batununggal;
        Console.WriteLine("Kelurahan " + lurah1.ToString() + " dengan Kode pos " + GetKodePos(lurah1));
        Kelurahan lurah2 = Kelurahan.Kujangsari;
        Console.WriteLine("Kelurahan " + lurah2.ToString() + " dengan Kode pos " + GetKodePos(lurah2));
        Kelurahan lurah3 = Kelurahan.Mengger;
        Console.WriteLine("Kelurahan " + lurah3.ToString() + " dengan Kode pos " + GetKodePos(lurah3));
        Kelurahan lurah4 = Kelurahan.Wates;
        Console.WriteLine("Kelurahan " + lurah4.ToString() + " dengan Kode pos " + GetKodePos(lurah4));
        Kelurahan lurah5 = Kelurahan.Cijaura;
        Console.WriteLine("Kelurahan " + lurah5.ToString() + " dengan Kode pos " + GetKodePos(lurah5));
        Kelurahan lurah6 = Kelurahan.Jatisari;
        Console.WriteLine("Kelurahan " + lurah6.ToString() + " dengan Kode pos " + GetKodePos(lurah6));
        Kelurahan lurah7 = Kelurahan.Margasari;
        Console.WriteLine("Kelurahan " + lurah7.ToString() + " dengan Kode pos " + GetKodePos(lurah7));
        Kelurahan lurah8 = Kelurahan.Sekejati;
        Console.WriteLine("Kelurahan " + lurah8.ToString() + " dengan Kode pos " + GetKodePos(lurah8));
        Kelurahan lurah9 = Kelurahan.Kebonwaru;
        Console.WriteLine("Kelurahan " + lurah9.ToString() + " dengan Kode pos " + GetKodePos(lurah9));
        Kelurahan lurah10 = Kelurahan.Maleer;
        Console.WriteLine("Kelurahan " + lurah10.ToString() + " dengan Kode pos " + GetKodePos(lurah10));
        Kelurahan lurah11 = Kelurahan.Samoja;
        Console.WriteLine("Kelurahan " + lurah11.ToString() + " dengan Kode pos " + GetKodePos(lurah11));
    }
}