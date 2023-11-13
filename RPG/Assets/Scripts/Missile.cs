using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", 6);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 newRotation = new Vector3(gameObject.transform.rotation.eulerAngles.x , gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 5);
        gameObject.transform.rotation = Quaternion.Euler(newRotation);
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
