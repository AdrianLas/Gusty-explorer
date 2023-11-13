using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Menu : State
{
    public Menu(Engine engine_source) : base(engine_source)
    {
    }
    public override IEnumerator Start()
    {
        return base.Start();
    }
    public override IEnumerator Run()
    {

        yield break;
    }
}