# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property of a class before it has been initialized.  This can lead to unexpected behavior or exceptions.

The `bug.cs` file contains code that attempts to use `MyProperty` without first ensuring it has a value.  The solution, in `bugSolution.cs`, demonstrates how to safely handle this situation by checking for initialization before use.