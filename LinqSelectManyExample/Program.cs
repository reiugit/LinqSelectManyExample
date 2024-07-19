
/// Example of using LINQ to get all variations of 3 characters from 3 strings

// 1. with LINQ query syntax
Print(from x in "ABC"
      from y in "123"
      from z in "123"
      select $"{x}{y}{z} ");

// 2. with LINQ method syntax and 1st overload of 'SelectMany'
//    (only with collection selector, needs nested select)
Print("ABC".SelectMany(x => "123".Select(y => $"{x}{y}"))
           .SelectMany(x => "123".Select(y => $"{x}{y} ")));

// 3. with LINQ method syntax and 2nd overload of 'SelectMany'
//    (with collection selector and result selector)
Print("ABC".SelectMany(x => "123", (x, y) => $"{x}{y}")
           .SelectMany(x => "123", (x, y) => $"{x}{y} "));

Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();

static void Print(IEnumerable<string> variations)
    => variations.ToList().ForEach(Console.Write);
