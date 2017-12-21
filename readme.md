# String Converter Project

Given Requirements:

> 1. Each word in the input string is replaced with the following: the first letter of the word, the count of distinct letters between the first and the last letter, and the last letter of the word. For example, "Automotive Parts" would be replaced by "A6e p3s" (Should be "A8e p3s")

> 2. A "word" is defined as a sequence of alphabetic characters, deliminated by any non-alphabetic characters.

> 3. Any non-alphabetic character in the input string should appear in the output string in its original relative location.

## Command Lines

### To run Convert program in Terminal
> dotnet run  --project Converter/Converter.csproj

### To run unit test
> dotnet test Converter_Tests/Converter_Tests.csproj
