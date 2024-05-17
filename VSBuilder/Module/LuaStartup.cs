using NLua;

namespace VSBuilder.Module
{
    class DoWorkClass
    {

        public void DoWork(int i)
        {

            Console.WriteLine(i);
        }
    }
    public class LuaStartup
    {
        string test(int iii)
        {
            Console.WriteLine(iii);
            return "У ска блять";
        }
        public LuaStartup()
        {
            try
            {
                Lua lua = new Lua();

                DoWorkClass doWork = new DoWorkClass();
                lua.RegisterFunction("DoWork", doWork, typeof(DoWorkClass).GetMethod("DoWork"));

                foreach (var item in Directory.GetFiles("Test", "*.lua"))
                {
                    var v = lua.DoFile(item);

                    Console.WriteLine(string.Join(" ", v));
                }


                //var v = lua.DoString("DoWork(10)").First();

                //Console.WriteLine(v);
            }
            catch (Exception)
            {

            }
        }
    }
}
