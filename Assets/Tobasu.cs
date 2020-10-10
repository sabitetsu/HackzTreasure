using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tobasu : MonoBehaviour
{
    public GameObject ball;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ButtonPushed()
    {
        Vector3 pos = ball.transform.position;
        pos.y += 5;
        ball.transform.position = pos;
    }
}
