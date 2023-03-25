using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    public Transform connectedNode;
        
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedNode.position.x, Time.deltaTime*20f),
            connectedNode.position.y,
            connectedNode.position.z + 1);
    }
}
