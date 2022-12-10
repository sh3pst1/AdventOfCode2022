namespace TheApp.Days
{
    public static class Day07
    {
        private static readonly List<string> Folders = new();
        private static readonly List<Directory> Result = new();
        private static string _currentDir = "";

        public static int Part1(string[] lines)
        {
            SetValues(lines);

            var value = 0;
            foreach (var folder in Folders)
            {
                var sum = Result.Where(x => x.Path.Contains(folder)).Select(z => z.TotalSize).Sum();
                if (sum <= 100000)
                {
                    value += sum;
                }
            }

            Console.WriteLine($"{nameof(Day07)}{nameof(Part1)} Result: {value}");
            return value;
        }

        public static int Part2(string[] lines)
        {
            SetValues(lines);
            var spaceFree = 70000000 - Result.Where(x => x.Path.Contains("*/")).Select(z => z.TotalSize).Sum();
            const int spaceNeeded = 30000000;
            
            var value = spaceNeeded;
            foreach (var folder in Folders.Where(x => x != "*/"))
            {
                var sum = Result.Where(x => x.Path.Contains(folder)).Select(z => z.TotalSize).Sum();
                if (spaceFree + sum >= spaceNeeded && sum < value)
                {
                    value = sum;
                }
            }
            
            Console.WriteLine($"{nameof(Day07)}{nameof(Part2)} Result: {value}");
            return value;
        }

        private static void SetValues(string[] lines)
        {
            _currentDir = string.Empty;
            Folders.Clear();
            Result.Clear();

            foreach (var line in lines)
            {
                if (line.StartsWith(Commands.List) || line.StartsWith(Commands.Dir))
                {
                    continue;
                }

                if (line.StartsWith(Commands.In) && !line.StartsWith(Commands.Out))
                {
                    var path = line.Replace(Commands.In, "");
                    _currentDir += "*" + path;
                    var folder = Folders.FirstOrDefault(x => x == _currentDir);
                    if (folder == null)
                    {
                        Folders.Add(_currentDir);
                    }
                }

                if (line.StartsWith(Commands.Out))
                {
                    var index = _currentDir.LastIndexOf("*", StringComparison.InvariantCulture);
                    _currentDir = _currentDir[..index];
                }

                if (char.IsNumber(line[0]))
                {
                    var fileSize = int.Parse(line.Split(" ")[0]);
                    var directory = Result.FirstOrDefault(x => x.Path == _currentDir);
                    if (directory == null)
                    {
                        directory = new Directory { Path = _currentDir };
                        Result.Add(directory);
                    }
                    directory.FileSizes.Add(fileSize);
                }
            }
        }
    }

    public class Directory
    {
        public string Path { get; set; }
        public List<int> FileSizes { get; set; } = new();
        public int TotalSize => FileSizes.Sum();
    }

    public static class Commands
    {
        public const string In = "$ cd ";
        public const string Out = "$ cd ..";
        public const string Dir = "dir ";
        public const string List = "$ ls";
    }
}
