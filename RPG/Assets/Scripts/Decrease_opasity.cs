using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decrease_opasity : MonoBehaviour
{
    public int scoreTreshold;
    private SpriteRenderer sprite;
    private Color color;
    private Engine engine;
    private Scene scene;
    public GameObject prefab;
    private int NewAreaReached;
    private GameObject holder;
    // Start is called before the first frame update
    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        engine = FindObjectOfType<Engine>();
        NewAreaReached = 0;
    }

    // Update is called once per frame
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
}
