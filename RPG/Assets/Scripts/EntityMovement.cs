using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    #region Variables
    public float movementSpeed;
    public float xPositionLeft;
    public float xPositionRight;
    #endregion

    #region Functions
    void Update()
    {
        Vector2 actualPosition = gameObject.transform.position;
        gameObject.transform.position = new Vector2(actualPosition.x-(Time.deltaTime*movementSpeed), actualPosition.y);
        if (gameObject.transform.position.x < xPositionLeft)
        {
            gameObject.transform.position = new Vector2(xPositionRight, actualPosition.y);
        }
    }
    #endregion
}
