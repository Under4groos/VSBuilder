
using NLua;
using VSBuilder.Module;
using VSBuilder.Module.lua_functions;


_File _File = new _File();
_object _Object = new _object();
while (true)
{
    using (Lua lua = new Lua())
    {
        lua.RegFunction("ReadFile", _File);
        lua.RegFunction("ToJson", _Object);
        lua.RegFunction("ToJsonObject", _Object);
        foreach (var item in Directory.GetFiles("Test", "*.lua"))
        {
            try
            {
                var v = lua.DoFile(item);

                Console.WriteLine(string.Join(" ", v));
            }
            catch (Exception)
            {


            }

        }
        lua.Dispose();
    }
    Console.ReadKey();
}




