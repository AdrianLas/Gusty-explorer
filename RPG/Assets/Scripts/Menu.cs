using System.Collections;

public class Menu : State
{
    #region Definitions
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
    #endregion
}