using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKAT
{
    public class Kafa
    {
        private string ime;
        private string poreklo;
        private string Ukus_i_Aroma;
       
        public string getIme
        {
            get { return ime; }
        }
        public string getPoreklo
        {
            get { return poreklo; }
        }
        public string getUkusAroma
        {
            get { return Ukus_i_Aroma; }
        }

        public string setIme
        {
            set { ime = value; }
        }
        public string setPoreklo
        {
            set { poreklo = value; }
        }
        public string setUkusAroma
        {
            set { Ukus_i_Aroma = value; }
        }

    }
    public class VrsteKafe:Kafa
    {
        public VrsteKafe(string ime, string poreklo, string Ukus_i_Aroma)
        {
            this.setIme = ime;
            this.setPoreklo = poreklo;
            this.setUkusAroma = Ukus_i_Aroma;
        }
      
        
        
        public void Ispis()
        {
            Console.WriteLine("Ime kafe: " + getIme);
            Console.WriteLine("Poreklo kafe: " + getPoreklo);
            Console.WriteLine("Ukus i aroma: " + getUkusAroma);
           
        }

    }
       

    public class PorodiceKafe
    {
        public void ispisiPorodice()
        {
            Console.WriteLine("\nPostoji mnogo vrsta zrna kafe, ali za pravljenje istoimenog napitka najvise se");
            Console.WriteLine("uzgajaju dve vrste: ARABIKA i ROBUSTA. \n");

        }
        public void Arabica()
        {
            Console.WriteLine("ARABIKA");
            Console.WriteLine("Smatra se da kafa arabika vodi poreklo iz jugozapadnih planinskih predela Etiopije. " +
                "\nVeruje se da je to bila i prva vrsta kafe koju su ljudi počeli da uzgajaju pre više od 1.000 godina. \n" +
                "Ova vrsta kafe najbolje uspeva na višim planinskim predelima, na nadmorskoj visini od 1.300 do 1.500 metara,\n" +
                "i to na područjima u kojima se temperatura vazduha kreće od 15 do 24 stepena, ali može da podnese i oštrije uslove.");
            Console.WriteLine("Trenutno je najviše u upotrebi na svetskom tržištu baš Arabika.\n\n");
        }
        public void Robusta()
        {
            Console.WriteLine("ROBUSTA");
            Console.WriteLine("Ova vrsta kafe potiče iz centralnog dela Afrike i zapadnog dela podsaharske poblasti. \n" +
                "bljika robuste može da dostigne visinu i do 10 metara. \n" +
                "Da bi bobice u kojima su zrna kafe sazrele, potrebno je 10-11 meseci.\n" +
                "Robusta je mnogo otpornija na spoljne uslove od arabike, a takodje i na upotrebu pesticida.\n" +
                "Smatra se da oko 25 odsto svetske proizvodnje kafe odlazi na robustu.\n" +
                "Robusta nije bila priznata kao vrsta kafe sve do 1897. godine.\n" +
                "Iz Etiopije i centralnog dela Afrike francuski kolonisti preneli su ovu biljku u Francusku Polineziju, \n" +
                "Borneo, Kostariku, Nikaragvu, Jamajku i na Male Antile.\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PorodiceKafe porodicekafe = new PorodiceKafe();
            porodicekafe.ispisiPorodice();

            PorodiceKafe porodica1 = new PorodiceKafe();
            porodica1.Arabica();

            PorodiceKafe porodica2 = new PorodiceKafe();
            porodica2.Robusta();


            Console.WriteLine("Postoje četiri vrste kafe, spremane na različite načine.");
            Console.WriteLine("Sve ostale poput Latte Macchiatto, Caffe Mocha su varijacije na temu.\n");
            List<string> vK = new List<string>();
            vK.Add("Crna Kafa");
            vK.Add("Espresso");
            vK.Add("Filter Kafa");
            vK.Add("Instant Kafa");
            foreach (string x in vK)
                Console.WriteLine("-" + x);

            VrsteKafe crnakafa = new VrsteKafe("Crna Kafa", "Arabijsko poluostrvo","Gorak ukus, aroma prave kafe!");
            VrsteKafe espresso = new VrsteKafe("Espresso", "Italija", "O ukusu i mirisu prave espresso kafe je teško pričati jer je jedinstven.\nJednostavno, espresso kafu morate probati!");
            VrsteKafe filterkafa = new VrsteKafe("Filter Kafa", "Francuska", "Ukus slican crnoj kafi, malo manje gorak.\nAroma je jedinstvena.");
            VrsteKafe instantkafa = new VrsteKafe("Instant Kafa", "Francuska", "Gorkog ukusa, aroma takodje jedinstvena.");

            Console.WriteLine("\nDa li biste želeli da znate nešto više o nekoj od ove četiri vrste? da/ne");
            string odgovor = Console.ReadLine();
            string odgovor1 = odgovor.ToUpper();
            if(odgovor1=="DA")
            {
                Console.WriteLine("\nO kojoj kafi biste želeli da znate nešto više?");
                Console.WriteLine("Izjasnite se ukucavanjem koda za odredjenu kafu.");
                Console.WriteLine("crnakafa / espreso / filterkafa / instantkafa\n");
                string Odgovor = Console.ReadLine();
                string Odgovor1 = Odgovor.ToUpper();
                if (Odgovor1 == "CRNAKAFA")
                {
                    crnakafa.Ispis();
                }
                else if (Odgovor1 == "ESPRESO")
                {
                    espresso.Ispis();
                }
                else if (Odgovor1 == "FILTERKAFA")
                {
                    filterkafa.Ispis();
                }
                else if (Odgovor1 == "INSTANTKAFA")
                {
                    instantkafa.Ispis();
                }
            }
            else if(odgovor1=="NE")
            {
                Console.WriteLine("U redu. Drago nam je da ste prisustvovali našoj prezentaciji kafe.\nPrijatan dan želimo.");
            }

            
        }
    }
}
