// Principles of value objects
// 1. Value objects are immutable
// 2. Value objects are compared by value (i.e. structural equality)
// 3. Value objects are always valid
// 4. Can have behavior

// Also, should not be able to use language features to get around any of the above

Console.WriteLine("Option 1");

var address1 = new ValueObjects.Option1.Address("123 Elm St", "Springfield", "IL");
var address2 = new ValueObjects.Option1.Address("123 Elm St", "Springfield", "IL");

Console.WriteLine(address1 == address2); // False

Console.WriteLine("Option 2");

var address3 = new ValueObjects.Option2.Address("123 Elm St", "Springfield", "IL");
var address4 = new ValueObjects.Option2.Address("123 Elm St", "Springfield", "IL");

Console.WriteLine(address3 == address4); // True

var address5 = new ValueObjects.Option2.Address("123 Elm St", "Springfield", "");

// NOTE: This should throw an exception

Console.WriteLine("Option 3");

try
{
    var address6 = new ValueObjects.Option3.Address("123 Elm St", "Springfield", "");
}
catch (ArgumentException)
{
    Console.WriteLine("Exception thrown as expected for empty state");
}

var address7 = new ValueObjects.Option3.Address("123 Elm St", "Springfield", "IL");
var address8 = address7 with { State = "" };

// NOTE: This should throw an exception

Console.WriteLine("Option 4");

var address9 = new ValueObjects.Option4.Address("123 Elm St", "Springfield", "IL");
var address10 = new ValueObjects.Option4.Address("123 Elm St", "Springfield", "IL");

Console.WriteLine(address9 == address10); // True

try
{
    var address11 = new ValueObjects.Option4.Address("123 Elm St", "Springfield", "");
}
catch (ArgumentException)
{
    Console.WriteLine("Exception thrown as expected for empty state");
}

// Following will not compile
//var address12 = address10 with { State = "" };

// Contains additional behavior
Console.WriteLine($"Is in IL: {address10.IsInState("IL")}");

Console.WriteLine("Option 5");

var address13 = new ValueObjects.Option5.Address("123 Elm St", "Springfield", "IL");
var address14 = new ValueObjects.Option5.Address("123 Elm St", "Springfield", "IL");

Console.WriteLine(address13 == address14); // True

try
{
    var address15 = new ValueObjects.Option5.Address("123 Elm St", "Springfield", "");
}
catch (ArgumentException)
{
    Console.WriteLine("Exception thrown as expected for empty state");
}

// Contains additional behavior
Console.WriteLine($"Is in IL: {address14.IsInState("IL")}");

Console.WriteLine("Done");

// RESULT: Option 4 is the winner. It meets all the criteria of a value object and is the simplest.
