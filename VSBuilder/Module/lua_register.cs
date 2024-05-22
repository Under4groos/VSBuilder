using NLua;

namespace VSBuilder.Module
{
    public static class lua_register
    {
        public static LuaFunction RegFunction(this Lua lua, string path, object target)
        {
            return lua.RegisterFunction(path, target, target.GetType().GetMethod(path));
        }
    }
}
