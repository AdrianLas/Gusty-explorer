using UnityEngine;
public class DestroyingAudioSources : MonoBehaviour
{
    #region Variables
    private float counter;
    #endregion

    #region Functions
    void Start()
    {
        counter = 0;
    }

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
    #endregion
}
