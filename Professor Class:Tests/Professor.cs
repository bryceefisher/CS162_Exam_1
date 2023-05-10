namespace Professor;

public class Professor
{
    //instance variables
    private int _lNumber;
    private string _fName;
    private string _lName;
    private string _department;
        
    //constructors
    public Professor()
    {
    }

    public Professor(int lNumber, string fName, string lName, string dept)
    {
        _lNumber = lNumber;
        _fName = fName;
        _lName = lName;
        _department = dept;
    }
        
    //properties
    public int LNumber
    {
        get { return _lNumber; }
        set
        {
            if (value.ToString().Length == 9)
            {
                _lNumber = value;
            }
            else
            {
                throw new ArgumentException("LNumber must be 9 characters long");
            }

        }
    }
    
    public string FirstName
    {
        get { return _fName; }
        set { _fName = value; }
    }
    
    public string LastName
    {
        get { return _lName; }
        set { _lName = value; }
    }
    
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    //methods
        
    public override string ToString()
    {
        return $"LNumber: {_lNumber}, Name: {_fName}, Last Name: {_lName}, Deptartment: {_department}";
    }
}
