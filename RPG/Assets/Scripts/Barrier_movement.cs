using UnityEngine;

public class Barrier_movement : MonoBehaviour
{
    #region Variables
    public GameObject Barrier;
    private Rigidbody2D rb;
    private Engine engine;
    #endregion

    #region Functions
    void Start()
    {
        engine = FindObjectOfType<Engine>();
        rb =Barrier.GetComponent<Rigidbody2D>();
        Barrier.transform.position = new Vector3(Barrier.transform.position.x , Random.Range(25f,260f), Barrier.transform.position.z);
    }

    private void FixedUpdate()
    {
        var step = 200 * Time.deltaTime * (1 + 0.005f * engine.score);
        Vector3 temp = new Vector3(-150, Barrier.transform.position.y, Barrier.transform.position.z);
            Barrier.transform.position = Vector3.MoveTowards(Barrier.transform.position, temp, step);
            if (Barrier.transform.position.x < -145)
            {
                Destroy(Barrier);
            }
        
    }
    #endregion
}
