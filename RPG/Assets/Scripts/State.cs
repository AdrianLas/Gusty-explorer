using System.Collections;

public abstract class State
{
    #region Variables
    protected Engine engine;
    #endregion

    #region Definitions
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
    #endregion
}
