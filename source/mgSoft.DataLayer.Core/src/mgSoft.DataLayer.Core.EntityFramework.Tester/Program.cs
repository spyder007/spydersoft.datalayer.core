using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mgSoft.DataLayer.Core.EntityFramework.Tester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var options = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder();
            options.UseSqlServer("Server=envy-mg\\SQL2014;Database=OneDev;Trusted_Connection=True;MultipleActiveResultSets=true");
            var dbProvider = new DataContextProvider(new DataContext(options.Options));

            var dataStore = new mgSoft.DataLayer.Core.EntityFramework.DataStore(dbProvider);
            var bev = dataStore.GetItem<Beverage>(6);


            var bevSave = new Beverage()
            {
                BeverageKey = "STRONGBOW-HONEY",
                Description = "Strongbow Hard Cider - Honey",
                ExternalInfo = null,
                Name = "Strongbow Honey"
            };

            bevSave = dataStore.SaveItem(bevSave);

            dataStore.DeleteItem(bevSave);
        }
    }
}
