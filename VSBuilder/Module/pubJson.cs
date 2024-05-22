using Newtonsoft.Json;

namespace VSBuilder.Module
{
    static class pubJson
    {
        public static string ObjToJsonString(this object o)
        {
            try
            {
                return JsonConvert.SerializeObject(o, Formatting.Indented);
            }
            catch (Exception)
            {

                return "error";
            }

        }

    }
}
