using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offset = Vector3.up * 5 + Vector3.back * 5;

    [SerializeField]
    private float damp = 3f;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var targetPos = target.position + target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * damp);
        transform.LookAt(target);
	}
}
