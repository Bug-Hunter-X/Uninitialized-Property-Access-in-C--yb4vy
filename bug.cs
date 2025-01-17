public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // The following line will cause an exception if MyProperty is not initialized.
        int value = MyProperty * 2; 
    }
}