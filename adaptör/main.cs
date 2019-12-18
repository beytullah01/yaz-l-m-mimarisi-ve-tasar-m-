class Program

	{

	    static void Main(string[] args)
	    {

	        Adapter adapter = new Adapter();
	        string tercih = null;

	        Client client = new Client();

	        try

	        {

	            while (true)

	            {
	                Console.WriteLine("Malzemenin tutarýný hesaplamak için 1 e," +

	                    "\niskontolu tutarýný hesaplamak için 2 ye," +

	                    "\nuygulamadan çýkmak için 3'e basýnýz.\n");

	                tercih = Console.ReadLine();
16
	                int secenek = Convert.ToInt32(tercih);

	                Console.WriteLine();

	 

	                if (secenek == 1)
	                {

	                    client.OdenecekMeblayiHesapla(new MalzemeTipineGoreToplamTutariniHesapla());

	                }

	                else if (secenek == 2)

	                {

	                    client.OdenecekMeblayiHesapla(new Adapter());

	                }

	                else

	                {

	                    return;
	                }

	            }

	        }

	        catch

	        {

	            Console.WriteLine("Hata ile karþýlaþýldý. Uygulama sonlanacaktýr.");

	            Thread.Sleep(1500);               

	        }

	    }

	}