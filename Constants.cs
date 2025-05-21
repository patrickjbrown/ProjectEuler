using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Constants
    {
        public const string INTRO_TEXT =
            "*------------------------------------------------------------------------------*\n" +
            "| Welcome to the ProjectEuler problem solver. This project is a showcase of my |\n" +
            "| algorithmic, mathematic and logic capabilities.                              |\n" +
            "|                                                                              |\n" +
            "| To generate the solution to a problem, type 'solve <id>'.                    |\n" +
            "| For a list of available problem ids, type 'list'.                            |\n" +
            "*------------------------------------------------------------------------------*";

        public const string PROBLEM_FORMAT =
            "*------------------------------------------------------------------------------*\n" +
            "  Problem {0}: {1}\n\n{2}\n\n  Answer: {3}\n" +
            "*------------------------------------------------------------------------------*";

        public const string COMMAND_PROMPT = "\n\nEnter command: ";

        public const string EXIT = "exit";
        public const string LIST = "list";
        public const string SOLVE = "solve";

        

        public const string SOLUTIONS_AVAILABLE = "  The following problem ids have solutions available:";
        public const string NO_SOLUTION = "No solution is available for that problem id.";
        public const string UNRECOGNIZED_COMMAND = "Unrecognized command.";

        public const string DIVIDER = "*------------------------------------------------------------------------------*";
    }
}
