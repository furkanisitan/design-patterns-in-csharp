using DependencyInjection.Abstract;

namespace DependencyInjection
{
    public class Sample
    {
        private IDisplayer _displayer;
        public string Msg { get; set; }

        internal Sample()
        {
            _displayer = null;
            Msg = string.Empty;
        }
        internal Sample(IDisplayer displayer)
        {
            _displayer = displayer;
        }

        public void Test()
        {
            _displayer.Display(Msg);
        }
    }
}
