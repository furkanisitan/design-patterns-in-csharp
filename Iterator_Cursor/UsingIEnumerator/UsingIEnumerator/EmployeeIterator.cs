using System.Collections;

namespace UsingIEnumerator
{
    class EmployeeIterator : IEnumerator
    {
        private int index = -1;
        private EmployeeContainer container;

        public EmployeeIterator(EmployeeContainer container)
        {
            this.container = container;
        }

        public object Current { get { return container.Items[index]; } }

        public bool MoveNext()
        {
            if (index < container.Items.Length - 1)
            {
                ++index;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
