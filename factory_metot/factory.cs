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