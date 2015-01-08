﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNLP.Tools.Util.Trees
{
    /// <summary>
    /// A mix-in interface for HeadFinders which support the
    /// makesCopulaHead method, which says how the HeadFinder in question handles "to be" verbs.
    /// </summary>
    public interface CopulaHeadFinder
    {
        bool MakesCopulaHead();
    }
}