using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Vector3 offset;
    private Transform target;
    //Range rango de camaras
    [Range (0,1)]public float lerpValue;
    //
    public float sensabilidad;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //permite mover la camara
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        // girar la camara con el raton
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensabilidad, Vector3.up) * offset;
        transform.LookAt(target);
    }
}
