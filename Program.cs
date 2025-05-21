using ProjectEuler.Problems;

namespace ProjectEuler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Constants.INTRO_TEXT);
            
            while (true)
            {
                Console.Write(Constants.COMMAND_PROMPT);
                var command = Console.ReadLine().ToLower();

                if (command.StartsWith(Constants.SOLVE))
                {
                    SolveProblem(command.Substring(Constants.SOLVE.Length));
                }
                else if (command == Constants.LIST)
                {
                    PrintAvailableProblemIds();
                }
                else if (command == Constants.EXIT)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Constants.UNRECOGNIZED_COMMAND);
                }
            }
        }

        private static void SolveProblem(string problemId)
        {
            Type type = Type.GetType(typeof(Problem).FullName + problemId.Trim());

            if (type != null && !type.IsAbstract)
            {
                Problem problem = (Problem)Activator.CreateInstance(type);
                Console.WriteLine(string.Format(Constants.PROBLEM_FORMAT, problem.Id, problem.Name, problem.Description, problem.GetSolution()));
            }
            else
            {
                Console.WriteLine(Constants.NO_SOLUTION);
            }
        }

        private static void PrintAvailableProblemIds()
        {
            var problems = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsSubclassOf(typeof(Problem)));

            Console.WriteLine("\n\n" + Constants.DIVIDER);
            Console.WriteLine(Constants.SOLUTIONS_AVAILABLE);

            foreach (var type in problems)
            {
                Console.WriteLine(type.Name.Replace("Problem", "  "));
            }

            Console.WriteLine(Constants.DIVIDER);
        }
    }
}
