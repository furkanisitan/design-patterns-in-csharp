using System.Collections.Generic;

namespace Observer_PublishSubscribe
{
    class Stock : IObservable
    {
        private int count;
        private List<Control> controls;

        public Stock()
        {
            controls = new List<Control>();
            count = 10;
        }

        public void GetItem()
        {
            --count;
            Notify();   // Değişiklik bildirimi
        }

        public void Notify()
        {
            foreach (Control control in controls)
            {
                control.OnAction(count.ToString());
            }
        }

        public void Register(Control control)
        {
            controls.Add(control);
        }

        public void UnRegister(Control control)
        {
            controls.Remove(control);
        }
    }
}
