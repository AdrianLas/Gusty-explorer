using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement2 : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 actualPosition = gameObject.transform.localPosition;
        gameObject.transform.position = new Vector2(actualPosition.x - (Time.deltaTime * movementSpeed), actualPosition.y);
        if (gameObject.transform.localPosition.x < -1270)
        {
            gameObject.transform.localPosition = new Vector2(1810, actualPosition.y);
        }
    }
}
