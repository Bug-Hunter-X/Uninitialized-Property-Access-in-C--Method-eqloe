public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before using it
        MyProperty = 10; 
        int value = MyProperty * 2; // Now MyProperty is initialized correctly
    }
    public void MyMethod2(){
        //Alternative: Use null-conditional operator to handle potential null values.
        int? value = MyProperty?.GetHashCode();
        if(value == null) {/* handle null case*/}
    }
} 