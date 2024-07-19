# Comparing the 1st and 2nd overload of<br>LINQ 'SelectMany' with LINQ Query Syntax

### Example of getting all variations of 3 characters from 3 strings using LINQ

1. with LINQ query syntax

<pre>
  from x in "ABC"
  from y in "123"
  from z in "123"
  select $"{x}{y}{z} ");
</pre>

2. with LINQ method syntax, using the **1st overload of 'SelectMany'**<br>
(only with collection selector, this needs an additional nested select)

<pre>
  "ABC".SelectMany(x => "123".Select(y => $"{x}{y}"))
       .SelectMany(x => "123".Select(y => $"{x}{y} ")));
</pre>

3. with LINQ method syntax, using the **2nd overload of 'SelectMany'**<br>
(with collection selector **and** result selector)

<pre>
  "ABC".SelectMany(x => "123", (x, y) => $"{x}{y}")
       .SelectMany(x => "123", (x, y) => $"{x}{y} "));
</pre>
