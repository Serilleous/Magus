using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class EditorWidthSnap : MonoBehaviour {

    public int snapValue = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x % snapValue != 0)
            Debug.Log(transform.localScale.x / snapValue);
	}
}
