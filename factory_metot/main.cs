 
static void Main(string[] args)
{
    Creator1 RaporCreator = new Creator1();
 
    IRapor rapor = RaporCreator.RaporFactory(RaporTip.Grafik);
    rapor.Olustur();
 
    rapor = RaporCreator.RaporFactory(RaporTip.Tablo);
    rapor.Olustur();
}