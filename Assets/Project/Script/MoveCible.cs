using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCible : MonoBehaviour
{
    public Transform Move1;
    public Transform Move2;
    public Transform Move3;
    public float timetomove;
    [SerializeField]
    private bool MoveCibletoposition1 = false;
    [SerializeField]
    private bool MoveCibletoposition2 = false;
    [SerializeField]
    private bool MoveCibletoposition3 = false;


    private void Update()
    {
        if (MoveCibletoposition1)
        {
            Vector3 a = transform.position;
            transform.position = Vector3.Lerp(a, Move1.position, timetomove);
        }
        else if(MoveCibletoposition2)
        {
            Vector3 a = transform.position;
            transform.position = Vector3.Lerp(a, Move2.position, timetomove);
        }
        else if (MoveCibletoposition3)
        {
            Vector3 a = transform.position;
            transform.position = Vector3.Lerp(a, Move3.position, timetomove);
        }
    }

    public void MoveCilbe1()
    {
        MoveCibletoposition1 = true;
        MoveCibletoposition2 = false;
        MoveCibletoposition3 = false;
        Debug.Log("MoveCilbe1");
    }

    public void MoveCilbe2()
    {
        MoveCibletoposition2 = true;
        MoveCibletoposition1 = false;
        MoveCibletoposition3 = false;
        Debug.Log("MoveCilbe2");

    }

    public void MoveCilbe3()
    {
        MoveCibletoposition1 = false;
        MoveCibletoposition2 = false;
        MoveCibletoposition3 = true;
        Debug.Log("MoveCilbe2");

    }
}
