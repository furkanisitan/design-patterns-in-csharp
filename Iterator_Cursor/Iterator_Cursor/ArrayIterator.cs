
namespace Iterator_Cursor
{
    class ArrayIterator : Iterator
    {
        private IKDepartment ik = new IKDepartment();
        private int index = 0;

        public object GetItem()
        {
            return ik.GetEmployees()[index++];
        }

        public bool Next()
        {
            return index < ik.GetEmployees().Length;
        }
    }
}
