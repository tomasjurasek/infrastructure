﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riganti.Utils.Infrastructure.Services.Logging
{
    public interface IExceptionFormatter
    {

        string FormatException(Exception ex);

    }
}
