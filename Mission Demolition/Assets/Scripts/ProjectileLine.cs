using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLine : MonoBehaviour
{
    //***Variables***//
    static public ProjectileLine S; //singleton

    [Header("Set in Inspector")]
    public float minDist = 0.1f;

    private LineRenderer line;
    private GameObject _poi;
    private List<Vector3> points;
    
    private void Awake()
    {
        S = this; // sets the singleton

        line = GetComponent<LineRenderer>(); //reference to lineRender
        line.enabled = false; // diable LineRender
        points = new List<Vector3>(); // new list

    } // end Awake()

    public GameObject poi
    {
        get { return (_poi);  }
        set { _poi = value;
            if(_poi != null)
            {
                line.enabled = false;
                points = new List<Vector3>();
                AddPoints();
            } //end if
        } // end set
    } // end poi()
   
}
