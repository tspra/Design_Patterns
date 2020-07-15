using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Partcipants.Visitor;

namespace Visitor_Pattern.Partcipants.Element
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
