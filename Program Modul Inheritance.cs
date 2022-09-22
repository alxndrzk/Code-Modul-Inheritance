class Mobil
{
    public string merk;
    public string tipe;
    public Ban ban;

    public void NyalakanMesin()
    {
        Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " menyala");
    }
    public void MatikanMesin()
    {
        Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " mati");
    }
}

class Toyota : Mobil
{
    public Toyota()
    {
        merk = "Toyota";
    }
}

class Agya : Toyota
{
    public Agya()
    {
        tipe = "Agya";
    }
}

class Innova : Toyota
{
    public Innova()
    {
        tipe = "Innova";
    }
}

class Avanza : Toyota
{
    public Avanza()
    {
        tipe = "Avanza";
    }
    public void NyalakanLampu()
    {
        Console.WriteLine("Lampu mobil " + merk + " bertipe " + tipe + " menyala");
    }
}
class Daihatsu : Mobil
{
    public Daihatsu()
    {
        merk = "Daihatsu";
    }
}

class Ayla : Daihatsu
{
    public Ayla()
    {
        tipe = "Ayla";
    }
}

class Xenia : Daihatsu
{
    public Xenia()
    {
        tipe = "Xenia";
    }
}

class Honda : Mobil
{
    public Honda()
    {
        merk = "Honda";
    }
}

class Brio : Honda
{
    public Brio()
    {
        tipe = "Brio";
    }
}

class Civic : Honda
{
    public Civic()
    {
        tipe = "Civic";
    }
    public void VtecKickedin()
    {
        Console.WriteLine("Ngeeeng Wooosh!!");
    }
}

class Ban
{
    public string merk;
}

class Michelin : Ban
{
    public Michelin()
    {
        merk = "Michelin";
    }
}

class Bridgestone : Ban
{
    public Bridgestone()
    {
        merk = "Bridgestone";
    }
}

class Tugas
{
    public static void Main(string[] args)
    {
        Mobil mobil1 = new Agya();
        mobil1.ban = new Michelin();
        mobil1.NyalakanMesin();
        mobil1.MatikanMesin();

        Mobil mobil2 = new Avanza();
        mobil2.ban = new Bridgestone();
        //mobil2.NyalakanLampu(); error karena method ini tidak dipunyai di class induk atau class mobil


        Civic civic1 = new Civic();
        civic1.ban = new Bridgestone();
        civic1.VtecKickedin();

        //Honda honda1 = new civic1();
        //honda1.Vteckickedin(); error karena methodnya tidak ada di class honda

    }
}