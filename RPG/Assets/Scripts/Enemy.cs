using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public GameObject prefab;
    public float power;
    public Animator animator;
    private bool trig;
    private float counter;
    void Start()
    {
        trig = true;
        player = GameObject.Find("Player");
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y > 30 && trig == true)
        {
            trig = false;
            StartCoroutine("Shoting");
        }
        if(trig)
        {
            Move(1);
        }
        else if(!trig)
        {
            counter += Time.deltaTime;
        }
        if(!trig && counter > 5)
        {
            Move(-1);
        }
        if(gameObject.transform.position.y < -200)
        {
            Destroy(gameObject);
        }
    }
    private void ShotOnPlayer()
    {
        animator.SetTrigger("attack");
        float multipler = power * 10000;
        Vector3 target = player.transform.position;
        Vector3 distance =target - gameObject.transform.position;
        distance = Vector3.Normalize(distance);
        GameObject temp = Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
        temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(distance.x*multipler, distance.y*multipler));
    }
    private IEnumerator Shoting()
    {
        yield return new WaitForSecondsRealtime(2);
        ShotOnPlayer();
        gameObject.GetComponent<AudioSource>().Play();
    }
    private void Move(float direction)
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, direction * 150 * Time.deltaTime + gameObject.transform.position.y);
    }
}
