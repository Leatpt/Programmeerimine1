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
            event2.MaxParticipants = 200;
            event2.Price = null;
            event2.Schedule = "1. 12:30 Väljaminek \r 2. 13:30 Tagasitulek";
            event2.IsPaidEvent = false;
            event2.Summary = null;
            event2.AttachedFiles = null;
            context.Events.Add(event2);

            context.SaveChanges();
        }
    }
}
