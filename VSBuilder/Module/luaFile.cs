namespace VSBuilder.Module
{
    public class luaFileProjectVS : luaFile
    {
        public string build(object config)
        {
            string jsonject_str = config.ObjToJsonString();
            dynamic dic__ = JsonConvert.DeserializeObject(jsonject_str);
            if (dic__["Values"] != null)
            {
                return Convert.dic__["Values"];
            }
            return jsonject_str;
        }

        public string[] GetProjects(string path)
        {

            if (!File.Exists(path))
                return Array.Empty<string>();

            string _solpath = new FileInfo(path).DirectoryName;
            List<string> path_projects = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            using (StreamReader sr = new System.IO.StreamReader(path))
            {
                while (!sr.EndOfStream)
                {

                    string sLine = sr.ReadLine();
                    if (sLine.StartsWith("Project"))
                    {
                        string[] sp_ = sLine.Split('=');
                        if (sp_.Length > 1)
                        {
                            sLine = sp_.Last().Trim();

                            sLine = Regex.Match(sLine, "\\\"[\\w\\\\\\.]+?\\.(csproj|vcxproj)").Value.Replace("\"", "");
                            path_projects.Add(Path.Combine(_solpath, sLine));
                        }


                    }


                }
            }
            return path_projects.ToArray();
        }
    }



}
