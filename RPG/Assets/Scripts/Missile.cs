using UnityEngine;

public class Missile : MonoBehaviour
{
    #region Functions
    void Start()
    {
        Invoke("Die", 6);
    }

    private void FixedUpdate()
    {
        Vector3 newRotation = new Vector3(gameObject.transform.rotation.eulerAngles.x , gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 5);
        gameObject.transform.rotation = Quaternion.Euler(newRotation);
    }
    #endregion

    #region Definitions
    void Die()
    {
        Destroy(gameObject);
    }
    #endregion
}
