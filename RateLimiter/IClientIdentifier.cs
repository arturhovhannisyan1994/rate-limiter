﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateLimiter
{
    public interface IClientIdentifier
    {
        string Id { get; }
    }
}