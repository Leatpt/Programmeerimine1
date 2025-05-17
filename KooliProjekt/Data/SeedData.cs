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

            context.SaveChanges();
        }
    }
}
