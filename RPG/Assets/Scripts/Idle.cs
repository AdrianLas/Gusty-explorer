using System.Collections;
using UnityEngine;

public class Idle : State
{
    #region Definitions
    public Idle(Engine engine) : base(engine)
    {

    }

    public override IEnumerator Start()
    {
        Time.timeScale = 0;
        return base.Start();
    }
    public override IEnumerator Run()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Time.timeScale = 1;
            engine.started = true;
            engine._setState(new PlayGame(engine));
        }
        yield break;
    }
    #endregion
}
