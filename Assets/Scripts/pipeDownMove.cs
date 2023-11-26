using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pipeDownMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float minY;
    public float maxY;
    public float moveRange;
    public float  moveSpeed;
    private Vector3 oldPosition;
    private float originX,originZ;
    private GameObject obj;
    void Start()
    {

        obj = gameObject;
        oldPosition = obj.transform.position;
        originX = obj.transform.position.x;
         originZ = obj.transform.position.z;
        minY = -1f;
        maxY = 2f;
        moveRange = 6f;
        moveSpeed =0.009f;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1*moveSpeed,0,0));
       
       void OnTriggerEnter2d(Collider2D other)
       {
         if (other.gameObject.tag.Equals("resetLocation"))
        {
            //  obj.transform.position =oldPosition;
             obj.transform.position = new Vector3(originX, Random.Range(minY, maxY + 1), originZ);
            //  oldPosition = obj.transform.position;
           

        }
       }

    }
}
