/// Product Interface
public interface IRapor
{
    void Olustur();
}
 
/// Concrete Product
public class RaporTablo : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Tablo þeklinde rapor");
    }
}

/// Concrete Product
public class RaporGrafik : IRapor
{
    public void Olustur()
    {
        Console.WriteLine("Grafik þeklinde rapor");
    }
}