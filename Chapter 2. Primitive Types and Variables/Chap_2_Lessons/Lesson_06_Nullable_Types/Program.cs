using System;

namespace Lesson_06_Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable Types - Nullable types are specific wrappers around the value types (as int, double and bool) that allow storing data with a null value.
            // Nullable types are reference types

            // Wrapping a given type as nullable can be done in two ways:
            Nullable<int> i1 = null;
            int? i2 = i1;


            int i = 5;
            int? ni = i;
            Console.WriteLine(ni); // 5  

            Console.WriteLine(ni.HasValue); // True
                                            // HashValue - Gets a value indicating whether the current System.Nullable`1 object has a valid value of its underlying type.
                                            // true if the current System.Nullable`1 object has a value; false if the current System.Nullable`1 object has no value.
            
            // i = ni; - this will fail to compile
            i = ni.Value;
            Console.WriteLine(i); // 5

            ni = null;
            Console.WriteLine(ni.HasValue); // False
            // i = ni.Value; // System.InvalidOperationException: "Nullable object must have a value."
            i = ni.GetValueOrDefault();  // Retrieves the value of the current System.Nullable`1 object, or the default value of the underlying type.
            Console.WriteLine(i); // 0


            // Nullable types are used for storing information, which is not mandatory.
            // For example, if we want to store data for a student such as the first name and last name as mandatory and age as not required,
            // we can use type int? for the age variable:

            string firstName = "Anders";
            string lastName = "Hejlsberg";
            int? age = null;
            Console.WriteLine(firstName + " " + lastName + " " + age);
        }
    }
}
