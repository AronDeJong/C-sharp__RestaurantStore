using System;
using System.Collections.Generic;
using VeganWebStore.Server.Service.Domain.Menu;
using VeganWebStore.Server.Src.Service.Logic;

namespace VeganWebStore.Server.Service.Logic
{
    class DefaultStoreService: StoreService {
        public Menu menu;


        public void addMenuItems(List<MenuItem> menuItems) {
            menuItems.ForEach(item => menu.addMenuItem(item));
        }


        public List<MenuItem> getMenuItems() {
            return menu.getMenuItems();
        }

        public MenuItem getMenuItemOnName(String name) {
            return getMenuItems().Find(item => item.Name.Equals(name));
        }

        public void addMenuItem(List<MenuItem> menuItems) {
            throw new NotImplementedException();
        }
    }
}
