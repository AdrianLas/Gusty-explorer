using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    // Start is called before the first frame update
    public Idle(Engine engine) : base(engine)
    {

    }

    // Update is called once per frame

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

}
