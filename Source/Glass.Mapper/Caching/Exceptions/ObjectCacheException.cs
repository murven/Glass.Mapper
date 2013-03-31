﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Caching.Exceptions
{
    public abstract class ObjectCacheException : Exception
    {
        protected ObjectCacheException(string message)
            : base(message)
        {
        }
    }
}
