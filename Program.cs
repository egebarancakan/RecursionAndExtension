internal class Program
{
    private static void Main(string[] args)
    {
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result = result*3;
        }
        Console.WriteLine(result);
        Islemler instance=new Islemler();
        Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar
        string ifade = "Ege Baran Çakan";
        bool sonuc=ifade.checkSpaces();
        Console.WriteLine(sonuc);
        if(sonuc==true)
        {
            Console.WriteLine(ifade.removeWhiteSpaces());
        }
        Console.WriteLine(ifade.makeUpperCase());
        Console.WriteLine(ifade.makeLowerCase());

        int[] dizi={9,3,6,2,5,0};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi=5;
        Console.WriteLine(sayi.isEven());

        string str="Ege Baran Çakan";
        Console.WriteLine(str.GetFirstCharacter());
    }
}

public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if(üs<2)
        {
            return sayi;
        }
        else
        {
            return Expo(sayi,üs-1)*sayi;
        }
    }
}

public static class Extension
{
    public static bool checkSpaces(this string param)
    {
        return param.Contains(" ");
    }
    
    public static string removeWhiteSpaces(this string param)
    {
        string[] dizi=param.Split(" ");
        return string.Join("",dizi);
    }

    public static string makeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string makeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)
    {
        foreach(var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool isEven(this int param)
    {
        return param%2==0;
    }

    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
}