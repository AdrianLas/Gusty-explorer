using UnityEngine;

public class Engine : StateMachine
{
    #region Variables
    public GameObject Barrier;
    public float score = 0;
    public bool started;
    public Vector3 playerVelocity = new Vector3(0, 0, 0);
    public GameObject[] enemies;
    private float timer;
    private float timeCounter;
    #endregion

    #region Functions
    void Start()
    {
        timeCounter = 0;
        timer = 1.8f;
        started = false;
        _setState(new Idle(this));
        InvokeRepeating("CreateEnemy", 0, 4);
    }

    void Update()
    {
        timeCounter += Time.deltaTime;
        if(timeCounter > timer / (1 + 0.005 * score))
        {
            Create_Barrier();
            timeCounter = 0;
        }
        Run();
    }
    #endregion

    #region Definitions
    void Create_Barrier()
    {
        Instantiate<GameObject>(Barrier);
    }
    void CreateEnemy()
    {
        if (score > 24)
        {
            Vector2 pos = new Vector2(Random.value * 500 + 500, -30);
            if (score > 74)
            {
                Instantiate(enemies[2], pos, gameObject.transform.rotation);
            }
            else if (score > 49)
            {
                Instantiate(enemies[1], pos, gameObject.transform.rotation);
            } else if (score > 24)
            {
                Instantiate(enemies[0], pos, gameObject.transform.rotation);
            }
        }
    }
    #endregion
}
