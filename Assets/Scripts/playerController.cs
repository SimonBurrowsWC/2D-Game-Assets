using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 1000;
    private float jumpforce = 300;
    [SerializeField] private LayerMask jumpableGround;
    public GameObject player;
    private Rigidbody2D playerRB;   
    private BoxCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            playerRB.AddForce(Vector3.right * -speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            playerRB.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        if (playerRB.velocity.x >= 10)
        {
            playerRB.velocity = new Vector3(10, playerRB.velocity.y, 0);
        }
        else if (playerRB.velocity.x <= -10)
        {
            playerRB.velocity = new Vector3(-10, playerRB.velocity.y, 0);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded())
        {
            playerRB.AddForce(Vector3.up * jumpforce);
        }
    }
    public bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }
}
