﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Medidata.RWS.Extras.AuditEvent
{
    /// <summary>
    /// Delegate that determines the shape of the method on subscribers
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="args">The <see cref="ODMAdapterEventArgs"/> instance containing the event data.</param>
    public delegate void ParsingCompleteEventHandler(object source, ODMAdapterEventArgs args);

}
