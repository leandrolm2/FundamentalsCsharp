namespace FundamentalsCsharp.Class3435
{
    //because enum is a new type, we declare at namespace level
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    internal class Lessons
    {
        public static void WorkWithEnums()
        {
            // Demonstrating how to retrieve the underlying value stored inside an enum
            var method = ShippingMethod.Express;
            Console.WriteLine($"Enum value: {(int)method}");

            // If you need to determine which member of the enum corresponds to an integer
            int methodId = 3;
            Console.WriteLine($"Enum member for value {methodId}: {(ShippingMethod)methodId}");

            // Outputting the string representation of the enum member
            Console.WriteLine($"Enum as string: {method.ToString()}");

            // In programming, parsing refers to converting a string to a different type
            var methodName = "Express";

            // Using Enum.Parse to convert the string methodName to its corresponding ShippingMethod enum value
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName, ignoreCase: true);
            // Breakdown of Enum.Parse parameters:
            // - typeof(ShippingMethod): Specifies the target enum type.
            // - methodName: The string representation of the enum member to be parsed.
            // - ignoreCase: true ensures case-insensitive parsing.

            // Now, shippingMethod contains the enum value corresponding to the string "Express"
        }
    }
}
