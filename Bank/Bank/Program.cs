using System;
using System.Threading;
namespace Bank
{

    public class Konto
    {
        public Konto()
        {
            imie = "Aleks";
            nazwisko = "Spychala";
            pesel = 1234567891012345678;
            numer_konta = 8901234567890123456;
            pin = 1234;
            stan_konta = 50;

        }
        public string imie;
        public string nazwisko;
        public long pesel;
        public long numer_konta;
        public int pin;
        public int stan_konta;





        //----------------------------------------------


        public void WypiszWszys()
        {
            Console.WriteLine("Imie: " + imie + "\nNazwisko: " + nazwisko + "\nPesel: " + pesel + "\nNumer konta: " + numer_konta + "\nStan konta: " + stan_konta);
        }
        //----------------------------------------------

        public void Sprpesel()
        {

        }
        //----------------------------------------------




        public void WypiszDane()
        {
            Console.WriteLine("Numer konta: " + numer_konta + "\nStan konta: " + stan_konta);
        }



        //----------------------------------------------
        public void Wyplac()
        {
            Console.WriteLine("Ile chcesz wyplacic?");
            int kwota = 0;

            string input = Console.ReadLine();
            Int32.TryParse(input, out kwota);
            if (kwota > stan_konta)
            {
                Console.WriteLine("Nie masz wystarczajacych srodkow na koncie!");
            }
            else
            {
                Console.WriteLine("Wyplacono " + kwota + "zl");
                stan_konta = stan_konta - kwota;
            }
        }

        //----------------------------------------------

        public void Wplac()
        {
            Console.WriteLine("Ile chcesz wplacic?");
            int kwota1 = 0;

            string input = Console.ReadLine();
            Int32.TryParse(input, out kwota1);

            Console.WriteLine("Wplacono " + kwota1 + "zl");
            stan_konta = stan_konta + kwota1;

        }




        //----------------------------------------------
        bool flaga1;
        int licznik1 = 1;
        public void ZmienPin()
        {
            do
            {
                Console.WriteLine("Podaj nowy pin");

                int pin1 = 0;
                string input = Console.ReadLine();
                Int32.TryParse(input, out pin1);
                if (licznik1 > 3)
                {
                    Console.WriteLine("Przekroczono liczbe proby zmiany pinu!!!");
                    flaga1 = true;
                }
                else
                {
                    if (pin1 <= 1000 || pin1 >= 10000)
                    {
                        Console.WriteLine("Nieprawidlowy pin!(" + licznik1 + ")");
                        licznik1++;
                        flaga1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Pin zostal zmieniony!");
                        pin = pin1;
                        flaga1 = true;
                    }
                }

            } while (flaga1 == false);





        }







        //----------------------------------------------

        public void WyplacMen()
        {
            Console.WriteLine("Ile chcesz wyplacic?\n1. 50zl\n2. 100zl\n3. 200zl\n4. 500zl");

            int wyplata = 0;
            string input = Console.ReadLine();
            Int32.TryParse(input, out wyplata);
            if (wyplata < 1 || wyplata > 4)
            {

                Console.WriteLine("nie wybrales poprawnej opcji");
            }
            else
            {
                if (wyplata == 1 && stan_konta >= 50)
                {
                    Console.WriteLine("Pomyslnie wyplacono 50 zl");
                    stan_konta = stan_konta - 50;
                }
                else
                {
                    if (wyplata == 2 && stan_konta >= 100)
                    {
                        Console.WriteLine("Pomyslnie wyplacono 100 zl");
                        stan_konta = stan_konta - 100;
                    }
                    else
                    {
                        if (wyplata == 3 && stan_konta >= 200)
                        {
                            Console.WriteLine("Pomyslnie wyplacono 200 zl");
                            stan_konta = stan_konta - 200;
                        }
                        else
                        {
                            if (wyplata == 4 && stan_konta >= 500)
                            {
                                Console.WriteLine("Pomyslnie wyplacono 500 zl");
                                stan_konta = stan_konta - 500;
                            }
                            else
                            {
                                Console.WriteLine("Nie masz tyle srodkow na koncie");
                            }
                        }
                    }
                }







            }





        }
















    }







    class Program
    {
        static void Main(string[] args)
        {
            Konto konto = new Konto();

            bool flaga;
            int pin2;
            do
            {
                int pesel1;
                Console.WriteLine("Podaj swoj pesel");

                string input = Console.ReadLine();
                Int32.TryParse(input, out pesel1);

                Console.WriteLine("Podaj swoj pin");

                string input1 = Console.ReadLine();
                Int32.TryParse(input1, out pin2);
                if (pin2 >= 1000 && pin2 < 9999)
                {
                    konto.pin = pin2;
                    flaga = true;

                }
                else
                {
                    Console.WriteLine("Cos poszlo nie tak");
                    flaga = false;
                }






            } while (flaga == false);



            int licznik = 1;
            Konto mojekonto = new Konto();
            do
            {

                int pin3;
                Console.WriteLine("LOGOWANIE\nPodaj PIN: ");
                string input = Console.ReadLine();
                Int32.TryParse(input, out pin3);

                if (pin3 == pin2)
                {
                    Console.WriteLine("Zalogowano\n---------------");
                    flaga = true;

                }
                else
                {
                    if (licznik == 3)
                    {
                        Console.WriteLine("Za duzo prob\nCzmychaj!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy pin(" + licznik + ")");
                        flaga = false;
                        licznik++;
                    }

                }

            } while (flaga == false);



            do
            {
                int numerek;
                Console.WriteLine("1. Stan konta\n2. Informacje o koncie\n3. Wyplata\n4. Szybka wyplata\n5. Wplata\n6. Zmiana PINU\n7. Koniec");
                string input = Console.ReadLine();
                Int32.TryParse(input, out numerek);
                if (numerek > 0 && numerek < 8)
                {

                    if (numerek == 1)
                    {
                        Console.WriteLine("---------------");
                        mojekonto.WypiszDane();
                        Console.WriteLine("---------------");
                        flaga = false;
                    }
                    else
                    {
                        if (numerek == 2)
                        {
                            Console.WriteLine("---------------");
                            mojekonto.WypiszWszys();
                            Console.WriteLine("---------------");
                            flaga = false;
                        }
                        else
                        {
                            if (numerek == 3)
                            {
                                Console.WriteLine("---------------");
                                mojekonto.Wyplac();
                                Console.WriteLine("---------------");
                                flaga = false;

                            }
                            else
                            {
                                if (numerek == 4)
                                {
                                    Console.WriteLine("---------------");
                                    mojekonto.WyplacMen();
                                    Console.WriteLine("---------------");
                                    flaga = false;
                                }
                                else
                                {
                                    if (numerek == 5)
                                    {
                                        Console.WriteLine("---------------");
                                        mojekonto.Wplac();
                                        Console.WriteLine("---------------");
                                        flaga = false;
                                    }
                                    else
                                    {
                                        if (numerek == 6)
                                        {
                                            Console.WriteLine("---------------");
                                            mojekonto.ZmienPin();
                                            Console.WriteLine("---------------");
                                            flaga = false;
                                        }
                                        else
                                        {
                                            if (numerek == 7)
                                            {
                                                for (int i = 1; i <= 6; i++)
                                                {

                                                    for (int j = 1; j <= 10; j++)
                                                    {

                                                        Console.Write("-");
                                                        Thread.Sleep(50);
                                                    }
                                                    Console.Write("Dowidzenia");


                                                }
                                                flaga = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Mozesz wybrac tylko opcje od 1 do 7!");
                    flaga = false;

                }


                //ALEKS SPYCHAŁA-----------------------------------------------

            } while (flaga == false);


        }
    }
}
