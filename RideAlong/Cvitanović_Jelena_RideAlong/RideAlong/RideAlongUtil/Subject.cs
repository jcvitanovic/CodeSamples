using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlongUtil
{
    public class Subject
    {
        private List<IObserver> listObservers = new List<IObserver>();

        public void addObserver(IObserver observer)
        {
            listObservers.Add(observer);
        }

        public void notify()
        {
            foreach (IObserver o in listObservers)
                o.Update();
        }
    }
}
