﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.Shared.Abstract
{
    public interface ISharedIdentityService
    {
        public string GetUserId { get; }
    }
}
