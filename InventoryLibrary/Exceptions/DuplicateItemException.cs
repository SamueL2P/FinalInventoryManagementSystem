﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Exceptions
{
    public class DuplicateItemException:Exception
    {
        public DuplicateItemException(string message):base(message) 
        {
            
        }
    }
}
