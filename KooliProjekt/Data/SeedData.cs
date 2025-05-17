using Microsoft.Extensions.Logging;
using System;

namespace KooliProjekt.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if(context.Events.Any())
            {
                return;
            }

            var event1 = new Event();
            event1.Name = "Suur Sündmus";
            event1.Date = new DateTime(2025, 8, 14, 14, 30, 0);
            event1.Description = "In a formatting operation, a standard format string is simply an alias for a custom format string.";
            event1.MaxParticipants = 200;
            event1.Price = 35;
            event1.Schedule = "1. Söök \r 2. Jook";
            event1.IsPaidEvent = true;
            event1.Summary = null;
            event1.AttachedFiles = null;
            context.Events.Add(event1);

            var event2 = new Event();
            event2.Name = "Ekskursioon Teatrimajas";
            event2.Date = new DateTime(2025, 7, 12, 12, 30, 0);
            event2.Description = "Kas soovid Estonia majast ja rahvusooperi tegemistest rohkem teada saada?Tule 1-tunnisele etenduse-eelsele ekskursioonile Estonia teatrisse, tutvu kauni ajaloolise hoonega ja vaata, mis toimub majas enne, kui eesriie tõuseb. Iga ekskursioon on unikaalne, nii nagu etenduski, mis igal õhtul erinev. Võib-olla saad jalutada lava taha, külastada mõnda töötuba või kohtuda oma teekonnal isegi lauljate-tantsijatega.";
            event2.MaxParticipants = 50;
            event2.Price = null;
            event2.Schedule = "1. 12:30 Väljaminek \r 2. 13:30 Tagasitulek";
            event2.IsPaidEvent = false;
            event2.Summary = null;
            event2.AttachedFiles = null;
            context.Events.Add(event2);

            var event3 = new Event();
            event3.Name = "Robert Plant Presents - Saving Grace featuring Suzi Dian";
            event3.Date = new DateTime(2025, 7, 24, 19, 30, 0);
            event3.Description = "Järgmisel kevadel ootab pühendunud muusikasõpru ees eriline maiuspala, sest Led Zeppelini legendaarne hääl Robert Plant tuleb lavale oma uue projektiga Saving Grace. 21. mail 2025 liitub Plantiga Tallinnas Alexela kontserdimaja laval andekas seltskond muusikuid, et tuua kuulajateni särav õhtu, kus minnakse sügavale helide imelisse maailma.";
            event3.MaxParticipants = 300;
            event3.Price = 65;
            event3.Schedule = "1. 19:30 Algus \r 2. 21:30 Lõpp";
            event3.IsPaidEvent = true;
            event3.Summary = null;
            event3.AttachedFiles = null;
            context.Events.Add(event3);

            var event4 = new Event();
            event4.Name = "Kaie Kõrbi Balletistuudio kevadkontsert";
            event4.Date = new DateTime(2025, 6, 24, 17, 00, 0);
            event4.Description = "JKaie Kõrbi balletistuudio kevadetendus — imeline teekond klassikalise tantsu võlumaailma.";
            event4.MaxParticipants = 100;
            event4.Price = 40;
            event4.Schedule = "Uksed avatakse: 17.00\r\nKontserdi algus: 18.00\r\nVaheaeg puudub\r\nKontserdi pikkus: 70 min\r\nKontserdi lõpp: 19.10";
            event4.IsPaidEvent = true;
            event4.Summary = null;
            event4.AttachedFiles = null;
            context.Events.Add(event4);

            var event5 = new Event();
            event5.Name = "Uno Loop 95";
            event5.Date = new DateTime(2025, 7, 24, 19, 30, 0);
            event5.Description = "Oled oodatud õhtule, mis on sama värvikas ja südantsoojendav kui Uno Loobi legendaarne muusika ise. Tuleme kokku, et tähistada legendaarse laulja ja muusiku 95. sünniaastapäeva ning meenutada meest, kes tahtis lapsena saada meremeheks, kuid õnneks jäi kaldale ja andis meile hoopis terve elu jagu imelisi laule. \r\n \r\nUno Loop ei olnud pelgalt muusik ja laulja – ta oli ka kitarriõpetaja ja eesti esimese eestikeelse kitarriõpiku autor, mille väljaandmisest möödub tänavu 60 – aastat. Nii võib öelda, et igal eestlasel, kes kitarri tinistab, on väike annus Uno Loopi vereringes. ";
            event5.MaxParticipants = 200;
            event5.Price = 40;
            event5.Schedule = "1. 19:30 Algus \r 2. 21:30 Lõpp";
            event5.IsPaidEvent = true;
            event5.Summary = null;
            event5.AttachedFiles = null;
            context.Events.Add(event5);

            var event6 = new Event();
            event6.Name = "Tähed Laval: Free Flow Studio 15";
            event6.Date = new DateTime(2025, 7, 21, 13, 30, 0);
            event6.Description = "Olete oodatud Free Flow Studio 15. juubelietendusele \"Tähed Laval\". Kogupere tantsu- ja muusikalavastuses astuvad üles nii Free Flow Studio tantsijad ja lauljad kui ka paljud tuntud artistid, kellega on au olnud jagada lava nende 15 aasta jooksul. Kindlasti näed laval ka mõnda kunagist tantsukava mõnest varasemast hooajast, palju tuttavaid nägusid läbi aegade taasühinenud lavalaudadel ning jagame ka tänusid ja auhindu.\r\n\r\nVõta sõber kaasa ja tule naudi õhtut täis head emotsiooni, loomingut ja toredaid üllatusi.";
            event6.MaxParticipants = 150;
            event6.Price = null;
            event6.Schedule = "1. 13:30 Algus \r 2. 16:30 Lõpp";
            event6.IsPaidEvent = false;
            event6.Summary = null;
            event6.AttachedFiles = null;
            context.Events.Add(event6);

            var event7 = new Event();
            event7.Name = "10 Tenors / Verdist Ed Sheerani hittideni";
            event7.Date = new DateTime(2025, 7, 11, 21, 30, 0);
            event7.Description = "Esmakordselt saab Eestis näha muusikaprojekti „10 tenorit“! Lavale astuvad sümfooniaorkester ja kümme Euroopa publiku poolt tunnustatud ja armastatud tenorit. Üheskoos toovad nad publikuni suurejoonelise vokaalse ja orkestrietenduse, mis ühendab klassikalise ja kaasaegse muusika.\r\n\r\n10 isiksust – 10 temperamenti. Need tenorid ei ole lihtsalt hääled, vaid iga tenor on omaette karakter oma ainulaadse loomingulise teekonna ja ereda lavalise esitusega. See on nagu vaataks ühte ja sama maailma läbi kümne erineva filtri.\r\n\r\n10 tenorit on kõrgeima taseme lauljad, kes esinevad juhtivatel ooperilavadel ja osalevad rahvusvahelistel konkurssidel.";
            event7.MaxParticipants = 500;
            event7.Price = 77;
            event7.Schedule = "1. 21:30 Algus \r 2. 23:30 Lõpp";
            event7.IsPaidEvent = true;
            event7.Summary = null;
            event7.AttachedFiles = null;
            context.Events.Add(event7);


            if (context.Customers.Any())
            {
                return;
            }

            var customer1 = new Customer();
            customer1.Name = "Pauliina Pihlakas";
            customer1.Email = "Pauliina@example.com";
            customer1.Phone = "+3721234567890";
            customer1.Address = "Liivalaia, Massiaru küla, Häädemeeste vald, Pärnu maakond, 86004";
            customer1.Discount = null;
            context.Customers.Add(customer1);

            var customer2 = new Customer();
            customer2.Name = "Peeter Kask";
            customer2.Email = "Peeter@example.com";
            customer2.Phone = "+3721244567890";
            customer2.Address = "Hobusepea tn 1, Kesklinna linnaosa, Tallinn, Harju maakond, 10133";
            customer2.Discount = 30;
            context.Customers.Add(customer2);

            var customer3 = new Customer();
            customer3.Name = "Pääru Ürgorg";
            customer3.Email = "P22ru@example.com";
            customer3.Phone = "+372164567890";
            customer3.Address = "Jõekalda tn 1, Pirita linnaosa, Tallinn, Harju maakond, 12012";
            customer3.Discount = 50;
            context.Customers.Add(customer3);

            context.SaveChanges();
        }
    }
}
