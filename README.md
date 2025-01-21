# Uninitialized Property Access in C# Method
This example demonstrates a common error in C#: accessing a property before it's been initialized.  Uninitialized properties will have their default values (0 for integers, null for objects, etc.). This can lead to unexpected results or exceptions if not handled carefully.

The `bug.cs` file shows the problem, while `bugSolution.cs` provides a corrected version.