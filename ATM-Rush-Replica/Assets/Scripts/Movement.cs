using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 3f;
    [SerializeField] float horizontalSpeed= 5f;
    float horizontal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal * horizontalSpeed * Time.deltaTime, 
                                        0f, 
                                        movementSpeed *Time.deltaTime));
    }


}
