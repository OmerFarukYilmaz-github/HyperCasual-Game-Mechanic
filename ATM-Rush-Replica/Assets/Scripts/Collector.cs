using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Collect")
        { //                         =  collectors transform
            other.transform.position = this.transform.position + Vector3.forward;
            Destroy(this.GetComponent<Collector>());
            other.gameObject.AddComponent<Collector>();
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<TailMovement>();
            other.gameObject.GetComponent<TailMovement>().connectedNode = transform;
            other.tag = "Collected";

        }
    }

}
