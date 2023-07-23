namespace Lesson6;


abstract class Mator { }
abstract class Karopka { }
abstract class BanKodu { }


class ZmzMator : Mator
{
    public ZmzMator()
    {
        Console.WriteLine("Zmz mator");
    }
}
class ZmzKaropka : Karopka
{
    public ZmzKaropka()
    {
        Console.WriteLine("Zmz karopka");
    }
}
class ZmzBankodu : BanKodu
{
    public ZmzBankodu()
    {
        Console.WriteLine("Zmz ban kodu");
    }
}


class LadaMator : Mator
{
    public LadaMator()
    {
        Console.WriteLine("Lada mator");
    }
}
class LadaKaropka : Karopka
{
    public LadaKaropka()
    {
        Console.WriteLine("Lada Karopka");
    }
}
class LadaBanKodu : BanKodu
{
    public LadaBanKodu()
    {
        Console.WriteLine("Lada ban kodu");
    }
}


class NazMator : Mator { }
class NazKaropka : Karopka { }
class NazBankodu : BanKodu { }




abstract class Factory
{
    public abstract Mator CreateMator();
    public abstract Karopka CreateKaropka();
    public abstract BanKodu CreateBankodu();
}

class ZmzFactory : Factory
{
    public override Mator CreateMator()
        => new ZmzMator();


    public override Karopka CreateKaropka()
        => new ZmzKaropka();

    public override BanKodu CreateBankodu()
        => new ZmzBankodu();
}

class LadaFactory : Factory
{
    public override Mator CreateMator()
        => new LadaMator();

    public override Karopka CreateKaropka()
        => new LadaKaropka();

    public override BanKodu CreateBankodu()
        => new LadaBanKodu();
}

class NazFactory : Factory
{
    public override Mator CreateMator()
        => new NazMator();

    public override Karopka CreateKaropka()
        => new NazKaropka();

    public override BanKodu CreateBankodu()
        => new NazBankodu();
}





class Program
{
    static void Main()
    {
        Factory factory1= new LadaFactory();

        factory1.CreateMator();
        factory1.CreateKaropka();
        factory1.CreateBankodu();

        Factory factory2 = new ZmzFactory();

        factory2.CreateMator();
        factory2.CreateKaropka();
        factory2.CreateBankodu();
    }
}