using System.ComponentModel;

namespace UsingINotifyPropertyChange
{
    class Stock : INotifyPropertyChanged
    {
        private string product;
        private int count;

        public string Product
        {
            get { return product; }
            set { product = value; OnChanged("Product"); }
        }
        public int Count
        {
            get { return count; }
            set { count = value; OnChanged("Count"); }
        }

        public Stock(string product, int count)
        {
            this.product = product;
            this.count = count;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnChanged(string propName)
        {
            // null değilse çalıştır
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
