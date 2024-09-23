using System.Linq;
using DuckGame;
using ModName.Core;

namespace ModName.Debug;

public class TestDraw : IInjectDrawable
{
    public void Draw()
    {
        Layer.Blocks.Begin(true);

        foreach (var profile in Profiles.active.Where(profile => profile is { duck.dead: false }))
            Graphics.DrawString("TestDraw.cs DRAW", profile.duck.GetPos(), Color.White);

        Layer.Blocks.End(true);
    }
}