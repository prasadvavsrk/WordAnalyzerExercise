# CSharpPractice1_WordAnalyzer

This is a simple exercise for practising C#.

It is based on a class called Analyzer, whose job is to perform some analysis on the words input to it. Analyzer is meant to 

1. Count the number of words
2. Find the length of the longest word
3. Find the word or words that are occur most frequently in the input

## Getting started

1. Fork a copy of the repository into your own github account.
2. Clone the repository to your local machine and check out the master branch
3. Open up the solution file in Visual Studio and build it
4. Go to WordAnalyzer\bin\Debug and run WordAnalyzer.exe
You should see something like 

```
C:\Repos\WordAnalyzer\WordAnalyzer\bin\Debug>WordAnalyzer.exe
WordAnalyzer.WordSource1: WordCount: 0, LongestWordLength: 0, MostCommonlyUsedWords:
WordAnalyzer.WordSource2: WordCount: 0, LongestWordLength: 0, MostCommonlyUsedWords:
WordAnalyzer.WordSource3: WordCount: 0, LongestWordLength: 0, MostCommonlyUsedWords:
```

WordAnalyzer.exe runs the Analyzer to analyze three different streams of input. However the analyzer hasn't been implemented: this is your task.

## The exercise
1. Write an implementation for Analyzer. There's no need to use TDD (since this exercise is about learning C#). 
Instead, you can run WordAnalyzer.exe whenever you want to test your code. When you've got a correct solution, that output should be

```
C:\Repos\WordAnalyzer\WordAnalyzer\bin\Debug>WordAnalyzer.exe
WordAnalyzer.WordSource1: WordCount: 404, LongestWordLength: 13, MostCommonlyUsedWords: the
WordAnalyzer.WordSource2: WordCount: 404, LongestWordLength: 13, MostCommonlyUsedWords: the
WordAnalyzer.WordSource3: WordCount: 0, LongestWordLength: 0, MostCommonlyUsedWords:
```

Check into your local repository as you go. Try to keep your check ins small.

2. Once you've got a working solution, try to improve it. Go over the code, extract methods, rename variables and so on to make it as easy to read as you can. 
Keep checking the code into your local repository as you go.

3. Now make a new branch called NoLoops. In this branch, you're going to develop a new solution that has no loops (no foreach, no for, and no while statements), and no recursive functions.
You will need to use Linq functions to achieve this! You can either start from scratch or you can refactor your current solution until there are no loops in it.

4. Now make a new another branch call NoIfs. Yes, you've guessed: no if statements, no case statements, and 
there's a special prize for anyone who doesn't use the : ? or the ?? operators.

Once you've done this, push your changes to your account. 
