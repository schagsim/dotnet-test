public class AutoHandler
{
    public static void VypisDetailyAuta(Auto auto)
    {
        Console.WriteLine($"Auto znacky {auto.Znacka}, o delce {auto.DelkaM}. Je to ctyrkolka? {(auto.JeToCtyrkolka ? "Ano" : "Ne")}");
    }
}

public class Auto
{
    public string Znacka;
    public double DelkaM;
    public bool JeToCtyrkolka;

    public Auto()
    {
        Znacka = "BezZnacky";
        DelkaM = 0;
        JeToCtyrkolka = false;
    }

    public Auto(string znackaParam, double delkaParam, bool jeToCtyrkolkaParam)
    {
        Znacka = znackaParam;
        DelkaM = delkaParam;
        JeToCtyrkolka = jeToCtyrkolkaParam;
    }

    public void VypisDetailyAuta()
    {
        Console.WriteLine($"Auto znacky {this.Znacka}, o delce {this.DelkaM}. Je to ctyrkolka? {(this.JeToCtyrkolka ? "Ano" : "Ne")}");
    }

    public static void JakDelaAuto()
    {
        Console.WriteLine("Auto dela vrum vrum");
    }

}

public static class ClassExample
{
    public static void RunClassExample()
    {
        Console.WriteLine("Zaciname Class Example");

        // Vytvor 3 triny auta.
        // Prvni instance bude Audi o delkce 4.7m a bude to ctyrkolka
        // Druha instance bude Skoda o delce 5.2m a nebude to ctyrkolka
        // Treti instance bude nic, jenom prazda instance.


        // Vypis detaily audiny pomoci funkce VypisDetailyAuta ve tride Auto a pomoci VypisDetailyAuta z tridy AutoHandler

    }
}