using System.Linq;
using DuckGame;
using ModName.Core;

namespace ModName.Debug;

internal class TestDrawUpdate : IInjectUpdateable, IInjectDrawable
{
    public void Update()
    {
        if (Keyboard.Pressed(Keys.F2))
            DevConsole.Log("TestDrawUpdate.cs F2 pressed");
    }

    public void Draw()
    {
        Layer.Blocks.Begin(true);
        
        Graphics.DrawString("TestDrawUpdate.cs\nTry Press F1 or f2\nand check\nthe console", Layer.Blocks.camera.center, Color.Yellow);

        Layer.Blocks.End(true);
    }
}