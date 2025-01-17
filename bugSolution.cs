public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Check if MyProperty has been assigned a value before using it.
        if (MyProperty != 0) //Or another suitable default value check based on your application logic
        {
            int value = MyProperty * 2;
            // ... further operations using the value
        }
        else
        {
            //Handle the case where the property hasn't been initialized
            Console.WriteLine("MyProperty has not been initialized.");
        }
    }
} 