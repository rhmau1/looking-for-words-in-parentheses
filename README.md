# looking-for-words-in-parentheses
**We will learn about how to get words or character inside of parentheses in C#** <br>
`IndexOf()` gives you the first position of a character or string inside of another string. <br>
`IndexOf()` returns -1 if it can't find a match. <br>
`Substring()` returns just the specified portion of a string, using a starting position and optional length. <br><hr>
Example: <br>
```C#
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
``` 
That code will return output like this: 
`inside the parentheses`
<br><hr>
We can use the `IndexOfAny()` method to find the first location of any of the string from selected array.<br>
And we can also use `LastIndexOf()` to find the final location of a string within another string. <br>
Source: https://learn.microsoft.com/id-id/training/modules/csharp-modify-content/2-exercise-indexof-substring
