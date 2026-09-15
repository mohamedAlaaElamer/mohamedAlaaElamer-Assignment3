namespace CSharpBasicsAssignment;
// ============================================================================
// PART A: Project & Structure
// ============================================================================
// 1. File and Folder Roles:
//    - .csproj: The project configuration file (build settings, dependencies, target framework).
//    - Program.cs: The entry point where application execution begins.
//    - obj/: Holds intermediate compiled files for fast incremental builds.
//    - bin/: Holds final binary outputs (.exe/.dll) ready for execution.
//
// 2. File-scoped namespace:
//    - Reduces indentation by not requiring enclosing curly braces { }.
//
// 3. Solution format:
//    - Classic .sln format is used.
//    - Advantage of .slnx: Clean, readable XML structure that is easier to merge in Git.
// ============================================================================

internal class Program
{
    struct Point
    {
        public int X;
        public int Y;
    }
    static void RunTypesDemo()
    {
        Console.WriteLine("\n=== PART B: Variables, Types & Casting ===");

        // Declarations & Runtime Types
        int intValue = 10;
        long longValue = 10000000000L;
        double doubleValue = 3.14;
        decimal decimalValue = 19.99m;
        bool boolValue = true;
        char charValue = 'A';
        string stringValue = "Hello, World!";
        var inferredValue = 42;

        Console.WriteLine($"int: {intValue}, type: {intValue.GetType()}");
        Console.WriteLine($"long: {longValue}, type: {longValue.GetType()}");
        Console.WriteLine($"double: {doubleValue}, type: {doubleValue.GetType()}");
        Console.WriteLine($"decimal: {decimalValue}, type: {decimalValue.GetType()}");
        Console.WriteLine($"bool: {boolValue}, type: {boolValue.GetType()}");
        Console.WriteLine($"char: {charValue}, type: {charValue.GetType()}");
        Console.WriteLine($"string: {stringValue}, type: {stringValue.GetType()}");
        Console.WriteLine($"inferred: {inferredValue}, type: {inferredValue.GetType()}");

        // Implicit Conversion (Widening: no data loss)
        long longFromInt = intValue; // 32-bit int fits safely inside 64-bit long
        int intFromChar = charValue; // 16-bit char fits safely inside 32-bit int
        Console.WriteLine($"Implicit long: {longFromInt}, char to int: {intFromChar}");

        // Explicit Conversion (Truncation vs Rounding)
        double sampleDouble = 3.7;
        int truncated = (int)sampleDouble; // Drops decimal part (Truncation -> 3)
        int rounded = Convert.ToInt32(sampleDouble); // Rounds to nearest integer (Rounding -> 4)
        Console.WriteLine($"Cast (int): {truncated}, Convert.ToInt32: {rounded}");

        // Integer Division Trap
        int divInt = 5 / 2;
        double divDouble = 5.0 / 2;
        // Integer division drops remainder (yields 2), whereas floating-point division preserves fraction (yields 2.5)
        Console.WriteLine($"5/2 = {divInt}, 5.0/2 = {divDouble}");

        // Boxing & Unboxing
        object boxed = intValue; // Boxing: allocated on heap
        int unboxed = (int)boxed; // Unboxing: explicit extraction
        Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}");

        // Parsing
        int parsedNumber = int.Parse("42");
        bool parseSuccess = int.TryParse("abc", out int tryResult);
        Console.WriteLine($"Parsed: {parsedNumber}, TryParse Succeeded: {parseSuccess}, Result: {tryResult}");

        // float to decimal: Attempt implicit assignment
        float floatVal = 5.5f;
        // decimal decVal = floatVal; // Compiler Error: Potential precision loss and different binary representation
        decimal explicitDec = (decimal)floatVal;
        Console.WriteLine($"Explicit decimal from float: {explicitDec}");

    }

    static void RunValueVsReferenceDemo()
    {
        Console.WriteLine("\n=== PART C: Value vs. Reference Types ===");

        // Experiment 1: Struct Copy Semantics (Value Type)
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1; // Creates an independent copy on the stack
        p2.X = 99;
        // p1.X and p2.X differ because value types copy the actual data
        Console.WriteLine($"p1.X: {p1.X}, p2.X: {p2.X}");

        // Experiment 2: Class Reference Semantics (Reference Type)
        Order o1 = new Order
        {
            OrderId = 1,
            CustomerName = "Ali",
            Quantity = 2,
            UnitPrice = 50m,
            DiscountPercent = 10,
            IsPaid = false,
            ShippingCity = "Cairo",
            Priority = 'H',
            ItemCode = 1001L
        };
        o1.CalculateTotal();

        Order o2 = o1; // Copies reference (memory address), both point to the same heap object
        o2.IsPaid = true;
        // o1.IsPaid and o2.IsPaid are both true because they share the same heap instance
        Console.WriteLine($"o1.IsPaid: {o1.IsPaid}, o2.IsPaid: {o2.IsPaid}");

        // Working with object
        object boxedOrder = o1; // No boxing occurs; o1 is a reference type, only address copied
        Order o3 = (Order)boxedOrder;
        Console.WriteLine($"ReferenceEquals(o1, o3): {object.ReferenceEquals(o1, o3)}");

        o2.PrintSummary();

        // Written explanation
        // Value types live on the stack; assigning them copies raw values.
        // Reference types store object data on the heap and references on the stack; assignment copies references.
        // Storing a reference type in an object variable does not box or duplicate
    }
    static void Main(string[] args)
    {
        Console.WriteLine("=== PART A: Project & Structure Complete ===");
        RunTypesDemo();
    }
}