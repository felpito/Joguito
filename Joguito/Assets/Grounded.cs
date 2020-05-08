using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    // Start is called before the first frame update

    private playerController pc;
    void Start()
    {
        pc = GetComponentInParent<playerController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            pc.isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            pc.isGrounded = false;
        }
    }
}
