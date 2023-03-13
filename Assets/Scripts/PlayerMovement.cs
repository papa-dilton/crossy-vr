using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerMovement : MonoBehaviour
{
    public GameObject person;
    ActionBasedController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //person.transform.Translate(Vector3.forward * Time.deltaTime * controller.rotateAnchorAction.action.ReadValue<Vector2>().y);
        //person.transform.Translate(Vector3.right * Time.deltaTime * controller.rotateAnchorAction.action.ReadValue<Vector2>().x);


    }
}
