## Contributing

**30 seconds of C#** is a community effort, so feel free to contribute in any way you can. Every contribution helps!

Here's what you can do to help:

- [Open issues](https://github.com/guepardoapps/30-seconds-of-c-sharp/issues/new) for things you want to see added or modified.
- Be part of the discussion by helping out with [existing issues](https://github.com/guepardoapps/30-seconds-of-c-sharp/issues).
- Submit [pull requests](https://github.com/guepardoapps/30-seconds-of-c-sharp/pulls) with snippets you have created (see below for guidelines).
- Fix typos in existing snippets, improve snippet descriptions and explanations or provide better examples.
- **Working on your first Pull Request?** You can learn how from this *free* series [How to Contribute to an Open Source Project on GitHub](https://egghead.io/series/how-to-contribute-to-an-open-source-project-on-github)

### Snippet submission and Pull request guidelines

- **DO NOT MODIFY THE README.md FILE!** Make changes to individual snippet files. We ([guepardoapps](https://www.github.com/guepardoapps/)) will update the `README.md` file when your pull request is merged.
- **Snippet filenames** must correspond to the title of the snippet and the topic it is connected to. For example, if your snippet is under the topic `### array` and is titled `### awesomeSnippet` the filename for should be `Array.AwesomeSnippet.cs` and the method name should be `AwesomeSnippet`.
  - Use `lowerCamelCase` for parameters and variables and `UpperCamelCase` for all other identifiers, not `kebab-case` or `snake_case`.
  -  Please follow the (dotnet)[https://docs.microsoft.com/en-US/dotnet/standard/design-guidelines/] guidelines.
- **Snippet titles** should have be the same as the name of the method that is present in the snippet.
  - Snippet titles must be unique (although if you cannot find a better title, just add some placeholder at the end of the filename and title and we will figure it out).
- **Snippet descriptions** must be short and to the point. Try to explain *what* the snippet does and *how* the snippet works and what **inbuilt** features/modules are used. Remember to include what functions you are using and why.
  - Snippet descriptions should be in the description header of the method
- **Snippets _CAN NOT_ use any external libraries or apis**. Only the libraries, apis and functions inbuilt in `C# 7.0`(upwards) shall be used.
- **Snippet example code** should be added next to the .cs-file and named equally to it but with file ending .md (e.g. Array.AwesomeSnippet.md)
- **Snippet example code** must be enclosed inside ` ```c# ` and ` ``` `.
  - Remember to start your snippet's code on a new line below the opening backticks.
  - You can write the code in any style you like but eventually it will be formated during pull request validation so the formatting will change.
  - Try to keep your snippets' code short and to the point. Use modern techniques and features. Make sure to test your code before submitting.
  - All snippets must be followed by one (more if necessary) test case after the code, in a new block enclosed inside ` ```c# ` and ` ``` `. The syntax for this is `MyMethod('testInput') # 'testOutput'`. Use multiline examples only if necessary.
  - Try to make your method name unique, so that it does not conflict with existing snippets.
  - Snippet methods do not have to handle errors in input, unless it's necessary (e.g. a mathematical method that cannot be extended to negative numbers should handle negative input appropriately).
- Snippets should be short (usually below 20 - 30 lines). If your snippet is longer than that, you can still submit it, and we can help you shorten it or figure out ways to improve it.
- Snippets *should* solve real-world problems, no matter how simple.
- Snippets *should* be abstract enough to be applied to different scenarios.
- It is not mandatory but highly appreciated if you provide **unit tests** and/or **performance tests**.
- You can start creating a new snippet, by using the [snippet template c#](Template.SnippetTemplate.cs) and [snippet template md](Template.SnippetTemplate.md) to format your snippets.
- You may add your name as `[Name][@github_username]` to the contributor database. If the snippet already exists and you are making changes to it you can add your name at the laste seperated by a comma.
<!--
### Additional guidelines and conventions regarding snippets

- If your snippet contains argument with default parameters, explain what happens if they are omitted when calling the method and what the default case is.
- If your snippet uses recursion, explain the base cases.
- If your variable is not changed anywhere in the code name it in uppercase.
- Use `UpperCamelCase` for method and `LowerCamelCase` for variable names if they consist of more than one word.
- Try to give meaningful names to variables. For example use `letter`, instead of `lt`. Some exceptions to convention are:
  - `arr` for lists (usually as the snippet method's argument).
  - `str` for strings.
  - `n` for a numeric value (usually as the snippet method's argument).
  - `val` or `v` for value (usually when iterating a list, mapping, sorting etc.).
  - `i` for indexes.
  - `func` for function arguments.
  - `nums` for lists of numbers.
- Use `()` if your method takes no arguments.
- Specify default parameters for arguments, if necessary. It is preferred to put default parameters last unless you have pretty good reason not to.
- Always use double quotes for string literals.
- Prefer using the ternary operator (`trueResult if condition else falseResult`) instead of `if else` statements whenever possible.
- Avoid nesting ternary operators (but you can do it if you feel like you should).
- Use lambda functions as much as possible, except when you can't.
- Leave a single space after a comma (`,`) character.
- Try to strike a balance between readability, brevity, and performance.-->