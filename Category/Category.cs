namespace MyCategory
{
    public struct Category
    {

        private int _categoryID;
        private string _categoryName;

        public int CategoryID
        {
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _categoryID = value;
                }
            }
            get { return _categoryID; }
            
        }

        public string CategoryName
        {
            set
            {
                if (value.Length <= 40)
                {
                    _categoryName = value;
                }
            }
            get { return _categoryName; }
        }

        public Category(int categoryID, string categoryName)
        {
            _categoryID = categoryID;
            _categoryName = categoryName;
        }

        public int GetCategoryNameLength()
            { return _categoryName.Length; }


    }

    public struct Structure1
    {
        public int x, y;
    }

    public class Class1
    {
        public int x, y;
    }

}
