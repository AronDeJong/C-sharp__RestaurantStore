using System;
using System.Collections.Generic;
using VeganWebStore.Server.Service.Domain.Menu;
using VeganWebStore.Server.Logic;

namespace VeganWebStore.Server.Logic {

    public class DefaultStoreService: StoreService {
        public Menu menu;

        public DefaultStoreService() {
            menu = new Menu();
        }

        public void addMenuItems(List<MenuItem> menuItems) {
            menuItems.ForEach(menuItem => addMenuItem(menuItem));
        }

        public List<MenuItem> getMenuItems() {
            return menu.getMenuItems();
        }

        public MenuItem getMenuItemOnName(String name) {
            return getMenuItems().Find(item => item.Name.Equals(name));
        }

        public void addMenuItem(MenuItem menuItem) {
            menu.addMenuItem(menuItem);
        }
    }
}
