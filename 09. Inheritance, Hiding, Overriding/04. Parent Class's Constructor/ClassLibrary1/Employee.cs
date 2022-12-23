﻿//parent class
public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    protected string _location;

    //constructor of parent class
    public Employee(int empId, string empName, string location)
    {
        this._empID = empId;
        this._empName = empName;
        this._location = location;
    }

    //properties
    public int EmpID
    {
        set
        {
            _empID = value;
        }
        get
        {
            return _empID;
        }
    }

    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
    }
}
