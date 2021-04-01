﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagementProject.Models
{
    public interface IRepo<t>
    {
        public void AddItem(t item);
        public IEnumerable<t> GetItems();
    }
}
