﻿using SophiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophiApp.Interfaces
{
    internal interface IHasChilds
    {
        List<TextedElement> ChildElements { get; set; }
    }
}
