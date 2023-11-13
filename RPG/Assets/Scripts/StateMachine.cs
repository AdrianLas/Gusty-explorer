using UnityEngine;

public abstract class StateMachine : MonoBehaviour
{
    #region Variables
    protected State state;
    #endregion

    #region Definitions
    public void _setState(State choosen_state)
    {
        state = choosen_state;
        StartCoroutine(state.Start());
    }
    public void Run()
    {
        StartCoroutine(state.Run());
    }
    #endregion
}
