using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : State
{
    public EndGame(Engine engine_source) : base(engine_source)
    {
    }

    // Start is called before the first frame update
    public override IEnumerator Start()
    {
        Time.timeScale = 0;
        return base.Start();

    }
    public override IEnumerator Run()
    {
        yield break;
    }
}
