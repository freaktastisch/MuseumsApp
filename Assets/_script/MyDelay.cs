using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDelay : MonoBehaviour {

    public float fseconds;

    IEnumerator Example()
    {
        Rigidbody rbDelayed = GetComponent<Rigidbody>();
        yield return new WaitForSeconds(fseconds);
        rbDelayed.isKinematic = false;
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
