﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomia.Store.Core.Services
{
    public interface IResellerProvider
    {
        Guid GetCurrentResellerId();
    }
}
