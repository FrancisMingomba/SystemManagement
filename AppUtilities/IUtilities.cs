﻿using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUtilities
{
   public interface IUtilities
    {

        public void CreateUser(Person person);
        public string FileData();
    }
}
