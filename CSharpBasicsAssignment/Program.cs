// ============================================================================
// PART A: Project & Structure
// ============================================================================
// 1. File and Folder Roles:
//    - .csproj: The project configuration file (build settings, dependencies, target framework).
//    - Program.cs: The entry point where application execution begins.
//    - obj/: Holds intermediate compiled files for fast incremental builds.
//    - bin/: Holds final binary outputs (.exe/.dll) ready for execution.
//
// 2. File-scoped namespace:
//    - Reduces indentation by not requiring enclosing curly braces { }.
//
// 3. Solution format:
//    - Classic .sln format is used.
//    - Advantage of .slnx: Clean, readable XML structure that is easier to merge in Git.
// ============================================================================

namespace CSharpBasicsAssignment;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PART A: Project & Structure Complete ===");
    }
}