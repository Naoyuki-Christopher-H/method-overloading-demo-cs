# Method Overloading Demo in C\#

This repository demonstrates **method overloading** in C#, a feature that allows multiple methods to share the same name but differ in the number or type of parameters.

## Overview

The concept of method overloading is illustrated through a simple `Multiply` method with three different versions:

1. **Multiply(double, double)** - Multiplies two double values
2. **Multiply(int, int)** - Multiplies two integer values
3. **Multiply(double)** - Squares a single double value

Each version has a unique **method signature**, which is a combination of the method name and parameter types. This allows the compiler to distinguish between them.

## Example Output

When the program is run, it produces output like:

```
Multiply(2.5, 3.5) = 8.75
Multiply(2, 3) = 6
Multiply(5.0) = 25
```

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/Naoyuki-Christopher-H/method-overloading-demo-cs.git
   ```

2. Open the solution in Visual Studio or your preferred C# IDE.

3. Build and run the project.

## Files

* `Program.cs` – Contains the `Main` method and the overloaded `Multiply` methods

## Concepts Demonstrated

* Method overloading
* Type inference
* Basic console I/O in C#

## Requirements

* .NET Framework or .NET SDK installed
* Compatible C# development environment (e.g., Visual Studio, Rider, VS Code with C# extensions)

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---
