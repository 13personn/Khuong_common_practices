using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class backGroundMove : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    private Vector3 oldPosition;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj =gameObject;
        oldPosition = obj.transform.position;
        moveSpeed =0.009f;
        moveRange =25f;
    }

    // Update is called once per frame
    void Update()
    {
       obj.transform. Translate(new Vector3(-1 *moveSpeed,0, 0));
    
    if(Vector3.Distance(oldPosition,obj.transform.position)>moveRange){
        obj.transform.position =oldPosition;

    }
    }
}
