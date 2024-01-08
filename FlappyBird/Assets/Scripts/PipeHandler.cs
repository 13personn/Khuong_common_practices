using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PipeHandler : MonoBehaviour
{

    public float minY, maxY, moveRange, moveSpeed;
    private Vector3 oldPosition, resetPosition;
    private float originX, originY, originZ;
    private GameObject obj;

    //
    //start
    //
    void Start()
    {

        obj = gameObject;

        oldPosition = obj.transform.position;
        originX = obj.transform.position.x;
        originY = obj.transform.position.y;
        originZ = obj.transform.position.z;
        resetPosition = new Vector3(10, originY, originZ);
        minY = -1f;
        maxY = 2f;
        moveRange = 22;
        moveSpeed = 2;
    }

    //
    //update
    //
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0, 0));
    }

    //
    //method
    //

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "resetLocation")
        {

            obj.transform.position = new Vector3(15, UnityEngine.Random.Range(minY, maxY + 1), originZ);

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "resetLocation")
        {
            Debug.Log(" pipe exit");


        }
    }
}
