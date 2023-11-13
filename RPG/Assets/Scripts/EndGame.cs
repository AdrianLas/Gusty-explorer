using System.Collections;
using UnityEngine;

public class EndGame : State
{
    #region Definitions
    public EndGame(Engine engine_source) : base(engine_source)
    {
    }

    public override IEnumerator Start()
    {
        Time.timeScale = 0;
        return base.Start();

    }
    public override IEnumerator Run()
    {
        yield break;
    }
    #endregion
}
