﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model.Customer
{
    public class AuthenticateRQ
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool rememberUser { get; set; }
    }
}
