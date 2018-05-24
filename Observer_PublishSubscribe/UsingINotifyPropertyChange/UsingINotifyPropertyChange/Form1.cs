using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UsingINotifyPropertyChange
{
    /*
    Stock sınıfının propertylerinin set metodlarında OnChanged() metodu çalıştırılmaktadır.
    Bu metod içinde ise PropertyChangedEventHandler tipinde bir event oluşturulmuştur.
    Oluşturulan bu event handle edilerek(stock_PropertyChanged), 
     değişiklik halinde yapılması istenen işlemler tanımlanmıştır.
    */
    public partial class Form1 : Form
    {
        private Stock stock = new Stock("Buzdolabı", 13);

        public Form1()
        {
            InitializeComponent();

            lblProduct.Text = stock.Product;
            lblCount.Text = stock.Count.ToString();

            stock.PropertyChanged += new PropertyChangedEventHandler(stock_PropertyChanged);

        }

        private void stock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Product":
                    lblProduct.Text = stock.Product;
                    break;
                case "Count":
                    lblCount.Text = stock.Count.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock.Count += 1;
        }
    }
}
