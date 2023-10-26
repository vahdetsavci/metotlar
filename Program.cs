using System;

namespace metotlar;

class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;

        Console.WriteLine(a+b);

        int sonuc1 = Topla(a, b);
        Console.WriteLine(sonuc1);

        Metotlar ornek = new Metotlar();
        ornek.EkranaYaz(sonuc1);

        int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
        ornek.EkranaYaz(sonuc2);
        ornek.EkranaYaz(a+b);
    }

    static int Topla(int deger1, int deger2)
    {
        return deger1 + deger2;
    }
}

class Metotlar
{
    public void EkranaYaz(object veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttırVeTopla(ref int deger1,ref int deger2)
    {
        deger1++;
        deger2++;
        return deger1 + deger2;
    }
}
