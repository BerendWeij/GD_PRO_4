 ﻿/*
* Gautham Prabhu K 2014
* Copyright (c) 2014  gautham.prabhu.se@gmail.com
* All rights reserved.
* No warranty of any kind implied or otherwise.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Event
{
    public interface ISubscriber<TEventType>
    {
        void OnEventHandler(TEventType e);
    }
}
