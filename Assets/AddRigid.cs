using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigid : MonoBehaviour
{
    Rigidbody rb;
    bool addRigid = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (addRigid == false)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                rb = gameObject.AddComponent<Rigidbody>();
                addRigid = true;
            }
        }
    }
}
