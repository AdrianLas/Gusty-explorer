using UnityEngine;

public class Decrease_opasity : MonoBehaviour
{
    #region Variables
    public int scoreTreshold;
    private SpriteRenderer sprite;
    private Color color;
    private Engine engine;
    public GameObject prefab;
    private int NewAreaReached;
    private GameObject holder;
    #endregion

    #region Functions
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        engine = FindObjectOfType<Engine>();
        NewAreaReached = 0;
    }

    void FixedUpdate()
    {
        if (engine.score >= scoreTreshold)
        {
            if (NewAreaReached == 0)
            {
                holder = Instantiate(prefab, gameObject.transform.position,gameObject.transform.rotation,gameObject.transform.parent.transform);
                holder.transform.parent = gameObject.transform.parent;
                NewAreaReached = 1;
            }
            color = sprite.color;
            if (color.a != 0)
            {
                sprite.color = new Color(color.r, color.g, color.b, color.a - 0.5f * Time.deltaTime);
            }
        if (sprite.color.a <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
    #endregion
}
