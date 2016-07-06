using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeganWebStore.Server.Service.Domain.Menu {

    public class Menu {
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

        public MenuItem getMenuItemOnTitle(String title) {
            return menuItems.Find(item => item.Name.Equals(title));
        }


    }

    public class MenuItem {
        readonly String title;
        readonly String description;
        readonly Decimal price;

        internal void print() {
            Console.WriteLine(
                "Name: {0} | Description: {1} | Price: {2}", 
                title, description, price);
        }



        private MenuItem(MenuItemBuilder builder) {
            this.title = builder.getTitle();
            this.description = builder.getDescription();
            this.price = builder.getPrice();
        }

        public string Name {
            get{ return title;}
        }

        public string Description {
            get{ return description;}
        }

        public decimal Price {
            get{ return price; }
        }

        public class MenuItemBuilder {
            String title;
            String description;
            Decimal price;

            public static MenuItemBuilder builder() {
                return new MenuItemBuilder();
            }

            public MenuItem build() {
                return new MenuItem(this);
            }

            public MenuItemBuilder setTitle(String title) {
                this.title = title; return this;
            }

            public MenuItemBuilder setDescription(String description) {
                this.description = description; return this;
            }

            public MenuItemBuilder setPrice(decimal price) {
                this.price = price; return this;
            }

            public String getTitle() {        return title; }
            public String getDescription() { return description; }
            public decimal getPrice() {      return price; }
        }
    }
}
