using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    protected State state;

    public void _setState(State choosen_state)
    {
        state = choosen_state;
        StartCoroutine(state.Start());
    }
    public void Run()
    {
        StartCoroutine(state.Run());
    }

}
