using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Collision : MonoBehaviour
{
    public GameObject player;
    public ActionBasedContinuousMoveProvider moveScript;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "car")
        {
            moveScript.enabled = false;
        }
    }
}
