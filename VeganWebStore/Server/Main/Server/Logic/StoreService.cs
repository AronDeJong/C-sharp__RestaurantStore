﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganWebStore.Server.Service.Domain.Menu;

namespace VeganWebStore.Server.Logic {
    public interface StoreService {

        void addMenuItems(List<MenuItem> menuItems);

        List<MenuItem> getMenuItems();
    }
}
