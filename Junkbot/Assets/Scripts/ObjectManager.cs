using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public Vector3 resetPos;
    public Quaternion resetRot;

    // Start is called before the first frame update
    void Start()
    {
        resetPos = transform.position;
        resetRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20 || gameObject.transform.position.y > -5)
        {
            transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = resetPos;

            transform.rotation = resetRot;
        }
    }
}
