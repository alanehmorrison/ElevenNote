namespace ElevenNote.Data.Migrations
{
    using ElevenNot.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ElevenNot.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ElevenNot.Data.ApplicationDbContext";
        }

        protected override void Seed(ElevenNot.Data.ApplicationDbContext context)
        {
            var notes = new List<Note>
            {
                new Note{Title = "Eat", Content = "Pizza Tonight", OwnerID = Guid.NewGuid(), CreatedUTC = new DateTimeOffset()}
            };
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
