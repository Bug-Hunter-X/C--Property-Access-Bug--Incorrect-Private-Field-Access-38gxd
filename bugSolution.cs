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
        // Correct way to modify the private field through the property
        int newValue = this.MyProperty + 10; 
        this.MyProperty = newValue;
    }
}