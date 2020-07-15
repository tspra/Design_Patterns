using Observer_Pattern.Participants.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Participants.Subject
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);

        void Notify();
    }
}
