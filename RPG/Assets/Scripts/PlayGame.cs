using System.Collections;

public class PlayGame : State
{
    #region Definitions
    public PlayGame(Engine engine_source) : base(engine_source)
    {
    }

    public override IEnumerator Start()
    {
        return base.Start();
    }
    public override IEnumerator Run()
    {
        if (!Movement.isAlive)
        {
            engine._setState(new EndGame(engine));
        }
        yield break;
    }
    #endregion
}
