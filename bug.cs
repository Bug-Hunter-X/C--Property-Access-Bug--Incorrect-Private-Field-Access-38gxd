public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // The following line is incorrect
        // It tries to access the private field directly through the property
        // which will not work correctly if the property has logic in the setter
        this.MyProperty = this._myField + 10; 
    }
}