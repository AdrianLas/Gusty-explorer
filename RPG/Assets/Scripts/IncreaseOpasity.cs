using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseOpasity : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Color color;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            color = sprite.color;
            if (color.a < 1)
            {
                sprite.color = new Color(color.r, color.g, color.b, color.a + 0.5f * Time.deltaTime);
            }
            if(sprite.color.a >= 1)
            {
                Destroy(this);
            }
    }
}
