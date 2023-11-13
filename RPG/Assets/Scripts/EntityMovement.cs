using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    public float movementSpeed;
    public float xPositionLeft;
    public float xPositionRight;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 actualPosition = gameObject.transform.position;
        gameObject.transform.position = new Vector2(actualPosition.x-(Time.deltaTime*movementSpeed), actualPosition.y);
        if (gameObject.transform.position.x < xPositionLeft)
        {
            gameObject.transform.position = new Vector2(xPositionRight, actualPosition.y);
        }
    }
}
