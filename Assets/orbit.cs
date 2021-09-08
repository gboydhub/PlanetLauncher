using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Transform target;
    public float orbitSpeed;
    public float negativeAcceleration;
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = (target.position - transform.position);
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Quaternion current = transform.localRotation;

        transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
        transform.Translate(negativeAcceleration * Time.deltaTime, 0, orbitSpeed * Time.deltaTime);
    }
}
