﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Config
{
    public class JwtConfig
    {
        public string Secret { get; set; } = string.Empty;
    }
}
