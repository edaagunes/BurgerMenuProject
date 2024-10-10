namespace Project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Project2BurgerMenu;

    internal sealed class Configuration : DbMigrationsConfiguration<Project2BurgerMenu.Context.BurgerMenuContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project2BurgerMenu.Context.BurgerMenuContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
