using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected Engine engine;
    // Start is called before the first frame update
    public State(Engine engine_source)
    {
        engine = engine_source;
    }
    public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator Run()
    {
        yield break;
    }


}
