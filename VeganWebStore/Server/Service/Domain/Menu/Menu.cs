using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganWebStore.Server.Service.Domain.Menu {

    class Menu {
        private List<MenuItem> menuItems;

        public Menu() {
            this.menuItems = new List<MenuItem>();
        }

        public void addMenuItem(MenuItem menuItem) {
            if(menuItem != null) {
                menuItems.Add(menuItem);
            }
        }


        public List<MenuItem> getMenuItems() {
            return menuItems;
        }

        public MenuItem getMenuItemOnName(String name) {
            return menuItems.Find(item => item.Name.Equals(name));
        }


    }

    internal class MenuItem {
        readonly String name;
        readonly String description;
        readonly Decimal price;

        internal void print() {
            Console.WriteLine(
                "Name: {0} | Description: {1} | Price: {2}", 
                name, description, price);
        }



        private MenuItem(MenuItemBuilder builder) {
            this.name = builder.getName();
            this.description = builder.getDescription();
            this.price = builder.getPrice();
        }

        public string Name {
            get{ return name;}
        }

        public string Description {
            get{ return description;}
        }

        public decimal Price {
            get{ return price; }
        }

        internal class MenuItemBuilder {
            String name;
            String description;
            Decimal price;

            public static MenuItemBuilder builder() {
                return new MenuItemBuilder();
            }

            public MenuItem build() {
                return new MenuItem(this);
            }

            public MenuItemBuilder setName(String name) {
                this.name = name; return this;
            }

            public MenuItemBuilder setDescription(String description) {
                this.description = description; return this;
            }

            public MenuItemBuilder setPrice(decimal price) {
                this.price = price; return this;
            }

            public String getName() {        return name; }
            public String getDescription() { return description; }
            public decimal getPrice() {      return price; }
        }
    }
}
