using NUnit.Framework;
using System.Collections.Generic;
using VeganWebStore.Server.Service.Domain.Menu;

namespace VeganWebStore.Server.Logic.Tests {
    [TestFixture]
    class StoreServiceTest {

        StoreService storeService = new DefaultStoreService();

        [Test]
        public void smokeTest() {
            Assert.NotNull(storeService);
        }

        [Test]
        public void givenInsert_expectToBeStored() {
            // Prepare: 
            var menuItemList = new List<MenuItem>();

            var name = "Vegan Duck";
            var description = "Vegan Duck with delicious sauce";

            menuItemList.Add(
                MenuItem.MenuItemBuilder.builder()
                .setTitle(name)
                .setDescription(description)
                .setPrice(2.1m)
                .build()
            );

            // Act:
            storeService.addMenuItems(menuItemList);

            // Verify:
            var menuItems = storeService.getMenuItems();
            var count = menuItems.Count;

            Assert.AreEqual(1, count);

            var firstItem = menuItems[0];
            Assert.AreEqual(name,         firstItem.Name);
            Assert.AreEqual(description,  firstItem.Description);
        }
    }
}