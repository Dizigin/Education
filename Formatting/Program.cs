﻿string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine(
format: "{0,-10} {1,6}",
arg0: "Name",
arg1: "Count");
Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: applesText,
arg1: applesCount);
Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: bananasText,
arg1: bananasCount);