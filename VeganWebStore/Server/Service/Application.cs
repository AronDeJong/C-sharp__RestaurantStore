using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganWebStore.Server.Service.Domain.Menu;

namespace VeganWebStore.Server.Service{

    class Application {
        private Menu menu;

        Application() {
            this.menu = new Menu();
        }

        void initializeMenu() {
            var menuItem = MenuItem.MenuItemBuilder.builder()
                .setName("Vegan Duck")
                .setDescription("Vegan Duck with delicious sauce")
                .setPrice(2.1m)
                .build();

            menu.addMenuItem(menuItem);

        }

        void start() {
            initializeMenu();
            var menuItems = menu.getMenuItems();

            System.Console.WriteLine("-- Now writing MenuItems --");
            menuItems.ForEach(mi => mi.print());
        }


        public static void Main(String[] args){
            new Application().start();
            Console.WriteLine("This is the main application");
        }
    }
}
