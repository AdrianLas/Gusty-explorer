using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement2 : MonoBehaviour
{
    #region Variables
    public float movementSpeed;
    #endregion

    #region Functions
    void FixedUpdate()
    {
        Vector2 actualPosition = gameObject.transform.localPosition;
        gameObject.transform.position = new Vector2(actualPosition.x - (Time.deltaTime * movementSpeed), actualPosition.y);
        if (gameObject.transform.localPosition.x < -1270)
        {
            gameObject.transform.localPosition = new Vector2(1810, actualPosition.y);
        }
    }
    #endregion
}
