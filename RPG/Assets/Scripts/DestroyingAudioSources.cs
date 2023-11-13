using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyingAudioSources : MonoBehaviour
{
    // Start is called before the first frame update
    private float counter;
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount > 0)
        {
            counter += Time.deltaTime;
        }
        if(counter > 3)
        {
            DestroyImmediate(gameObject.transform.GetChild(0).gameObject);
            counter = 0;
        }
    }
}
