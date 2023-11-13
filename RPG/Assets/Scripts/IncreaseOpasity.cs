using UnityEngine;
public class IncreaseOpasity : MonoBehaviour
{
    #region Variables
    private SpriteRenderer sprite;
    private Color color;
    #endregion

    #region Functions
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

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
    #endregion
}
