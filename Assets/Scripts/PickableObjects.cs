using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObjects : MonoBehaviour
{
    public bool isPickable = true;
    //public PlayerController pc;
    // Start is called before the first frame update
    //cuando el objeto esta dentro del las manos ejecutar algo
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = this.gameObject;
        }
    }

    // cambiar estado all aejarse del objeto
    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObjects>().ObjectToPickUp = null;
            //pc.movePlayerContainer(true);
        }
    }
}