﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eg.Core
{
    public abstract class Entity
    {
        public virtual Guid Id { get; protected set; }
    }
}