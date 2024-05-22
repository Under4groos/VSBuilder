namespace VSBuilder.Module.lua_functions
{
    public class _File
    {
        public string[] ReadFile(string path)
        {
            if (File.Exists(path))
                return File.ReadLines(path).ToArray();
            return Array.Empty<string>();
        }
    }
}
