public struct Category
{
    //private field
    private int _categoryID;
    private string _categoryName;

    //public fields
    public int CategoryID
    {
        set
        {
            if (value >= 1 && value <= 100)
            {
                _categoryID = value;
            }
        }
        get
        {
            return _categoryID;
        }
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
        get
        {
            return _categoryName;
        }
    }

    public int GetCategoryNameLength()
    {
        return this._categoryName.Length;
    }
}

