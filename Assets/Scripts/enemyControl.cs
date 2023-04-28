using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    private float speed = 1000;
    private Rigidbody2D enemyRB;
    public int enemyBehavior = 1;
    public GameObject playerGO;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        playerGO = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyBehavior == 0)
        {

        }
        else if (enemyBehavior == 1)
        {
            Erratic();
        }
        else if (enemyBehavior == 2)
        {
            FollowPlayer();
        }
        else
        {
            Debug.Log("Impropper State");
        }
    }

    float Round(float Float, int decimal_places)
    {
        return Mathf.Round(Float * Mathf.Pow(10, (decimal_places)) / Mathf.Pow(10, decimal_places));
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wand")
        {
            enemyBehavior++;
            if (enemyBehavior > 2)
            {
                enemyBehavior = 0;
            }
        }
    }
    void Erratic()
    {
        enemyRB.AddForce(Vector3.right * speed * Time.deltaTime);
        if (Round(enemyRB.velocity.x, 4) == 0)
        {
            speed = speed * -1;
            while (Round(enemyRB.velocity.x, 1) != 0)
            {
                enemyRB.AddForce(Vector3.right * speed * Time.deltaTime);
            }
        }
        if (enemyRB.velocity.x >= 5)
        {
            enemyRB.velocity = new Vector3(5, enemyRB.velocity.y, 0);
        }
        else if (enemyRB.velocity.x <= -5)
        {
            enemyRB.velocity = new Vector3(-5, enemyRB.velocity.y, 0);
        }
    }
    void FollowPlayer()
    {
        if (playerGO.transform.position.x > enemyRB.transform.position.x)
        {
            speed = 1000;
        }
        else if (playerGO.transform.position.x < enemyRB.transform.position.x) 
        {
            speed = -1000;
        }
        enemyRB.AddForce(Vector3.right * speed * Time.deltaTime);
    }
}