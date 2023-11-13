using UnityEngine;

public class DestroyOnW : MonoBehaviour
{
    #region Functions
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Destroy(gameObject);
        }
    }
    #endregion
}
