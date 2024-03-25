using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinwheelControlller : MonoBehaviour
{
    public float rotationSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        transform.rotation = transform.rotation * deltaRotation;
    }
}
