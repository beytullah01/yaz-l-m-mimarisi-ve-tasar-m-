
public interface IRapor
{
    void Olustur();
}
 
public class RaporTablo : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Tablo �eklinde rapor");
    }
}
 

public class RaporGrafik : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Grafik �eklinde rapor");
    }
}
public IRapor RaporFactory(RaporTip raporTip)
{
    IRapor rapor = null;
    switch (raporTip)
    {
        case RaporTip.Tablo:
            rapor = new RaporTablo();
            break;
        case RaporTip.Grafik:
            rapor = new RaporGrafik();
            break;
        default:
            break;
    }
    return rapor;
}
 


 
