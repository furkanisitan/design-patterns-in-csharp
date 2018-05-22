
namespace Iterator_Cursor
{
    ListIterator : Iterator
    {
        private ADKDepartment adk = new ADKDepartment();
        private int index = 0;

        public object GetItem()
        {
            return adk.GetEmployees()[index++];
        }

        public bool Next()
        {
            return index < adk.GetEmployees().Count;
        }
    }
}
