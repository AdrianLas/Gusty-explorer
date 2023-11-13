using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    public Engine Engine;
    public static bool isAlive;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.isPaused && isAlive)
        { 
            if (Input.GetKeyDown(KeyCode.W))
            {
                Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000000));
                AudioSource temp = Player.GetComponent<AudioSource>();
                temp.Play();
            }
            if (animator.GetBool("isFlying") && Player.GetComponent<Rigidbody2D>().velocity.y < 0)
            {
                animator.SetBool("isFlying", false);

            }
            else if (!animator.GetBool("isFlying") && Player.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                animator.SetBool("isFlying", true);
            }
            if (animator.GetBool("isFlying"))
            {
                Rotate(45f);
            }
            else
            {
                Rotate(-45f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Engine.score += 1;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
    }
    private void Rotate(float angle)
    {
        Quaternion target = Quaternion.Euler(0, 0, angle);
        Player.transform.rotation = Quaternion.Slerp(Player.transform.rotation, target, Time.deltaTime * 5.0f);

    }
}
