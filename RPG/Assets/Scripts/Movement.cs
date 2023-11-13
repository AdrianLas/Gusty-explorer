using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Variables
    public GameObject Player;
    public Engine Engine;
    public static bool isAlive;
    public Animator animator;
    #endregion

    #region Functions
    void Start()
    {
        isAlive = true;
    }

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
    #endregion

    #region Definitions
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
    #endregion
}
