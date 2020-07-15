﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.Element;

namespace Visitor_Pattern.Partcipants.Visitor
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
