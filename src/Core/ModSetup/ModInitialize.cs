using DuckGame;
using ModName.Core.Factories;

namespace ModName.Core.ModSetup
{
    internal static class ModInitialize
    {
        public static void PreInitialize()
        {
            DevConsole.Log("MOD INITIALIZED");
        }
        public static void PostInitialize()
        {
            new UpdateableFactory().CreateAll();
            new DrawableFactory().CreateAll();
        }
    }
}
