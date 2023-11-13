using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : State
{
    public PlayGame(Engine engine_source) : base(engine_source)
    {
    }

    // Start is called before the first frame update
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

}
