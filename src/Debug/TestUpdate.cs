using DuckGame;
using ModName.Core;

namespace ModName.Debug;

public class TestUpdate : IInjectUpdateable
{
    public void Update()
    {
        if (Keyboard.Pressed(Keys.F1))
            DevConsole.Log("TestUpdate.cs F1 pressed");
    }
}