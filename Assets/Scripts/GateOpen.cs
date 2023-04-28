using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    private Rigidbody2D gateRB;
    public bool up = false;
    // Start is called before the first frame update
    void Start()
    {
        gateRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (up == true)
        {
            transform.position = new Vector3(7, -2, 0);
        }
        else
        {
            transform.position = new Vector3(7, -5, 0);
        }
    }
    public void platesdown()
    {
        up = true;
    }
    public void plateup()
    {
        up = false;
    }
}
