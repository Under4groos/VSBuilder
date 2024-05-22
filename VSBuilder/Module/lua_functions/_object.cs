using Newtonsoft.Json;

namespace VSBuilder.Module.lua_functions
{
    public class _object
    {
        public string ToJson(object o)
        {
            try
            {
                return JsonConvert.SerializeObject(o, Formatting.Indented);
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }
        public dynamic ToJsonObject(string o)
        {
            try
            {
                return JsonConvert.DeserializeObject(o);
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }
    }
}
