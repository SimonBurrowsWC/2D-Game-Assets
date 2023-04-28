using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perssurePlate : MonoBehaviour
{
    public GameObject gate;
    public bool open;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" | other.tag == "Enemy")
        {
            gate.GetComponent<GateOpen>().platesdown();
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" | other.tag == "Enemy")
        {
            gate.GetComponent<GateOpen>().plateup();
        }
    }
}