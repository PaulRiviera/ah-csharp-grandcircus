﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogAPI.Models
{
    public class PingResponse
    {
        public string Status { get; set; }
        public long Ticks { get; set; }
    }
}
