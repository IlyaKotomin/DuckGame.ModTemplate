//Kotxik`s mod template

using DuckGame;

namespace ModName.Core.ModSetup
{
    public class ModName : DisabledMod
    {
        public override Priority priority => base.priority;
        protected override void OnPreInitialize()
        {
            base.OnPreInitialize();
            ModInitialize.PreInitialize();
        }
        protected override void OnPostInitialize()
        {
            ModInitialize.PostInitialize();

            base.OnPostInitialize();
        }
    }
}
