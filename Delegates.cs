using System;

namespace CSharp
{
    public class Delegates
    {
        // A delegate is  type that safely encapsulates a method, similar to a function pointer in C++.
        // Delegate syntax:  <access modifier> delegate <return type> <delegate_name>(<parameters>)
        // The following example declares a delegate named Del that can encapsulate a method that takes a string as an argument and returns a void:
        public delegate void Del(string message);

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        // Instantiate the delegate
        Del handler = DelegateMethod;

        // Call the delegate
        public void CallDelegate()
        {
            handler("Hello World");
        }
    }
}
