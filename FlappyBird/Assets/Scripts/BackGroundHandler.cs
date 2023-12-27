using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class BackGroundHandler : MonoBehaviour
{
    public float moveSpeed, moveRange;
    private Vector3 oldPosition;
    private GameObject obj;
 //
 //Start
 //
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
        moveSpeed = 1;
        moveRange = 15f;
    }
//
// Update 
//
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * moveSpeed * Time.deltaTime, 0, 0));

        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;

        }
    }
}
