using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObjects : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    public GameObject PickedObject;
    public Transform interactionZone;
    // Coger objetos
    void Update()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObjects>().isPickable == true && PickedObject == null)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<PickableObjects>().isPickable = false;
                PickedObject.transform.SetParent(interactionZone);
                PickedObject.transform.position = interactionZone.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;
                GetComponent<PlayerController>().moverRepair = true;

            }
        }
        else if (PickedObject != null)
        {
            if(Input.GetKeyUp(KeyCode.Q))
            {
                PickedObject.GetComponent<PickableObjects>().isPickable = true;
                PickedObject.transform.SetParent(null);
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject = null;
                GetComponent<PlayerController>().moverRepair = false;
            }
            
        }
    }
}
