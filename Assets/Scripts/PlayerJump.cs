using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private AudioSource jumpSfx;
    private Rigidbody2D rb;
    private Animator anim;
    private float jumpForce  = 7;
    private bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        jumpSfx.time = 0.18f;
        rb = transform.GetComponent<Rigidbody2D>();
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (canJump){
                jumpSfx.Play();
                canJump = false;
                rb.velocity = Vector2.up * jumpForce;
                anim.SetBool("isJumping", true);
            }
        }
        else{
                anim.SetBool("isJumping", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        //Controls the player jumps on the ground
        if (other.collider.tag == "Ground"){
            canJump = true;
        }
    }
}
