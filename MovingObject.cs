using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingObject : MonoBehaviour {

    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxCollider;
    private Rigidbody2D rb2D;
    private float inverseMoveTime;


	// Use this for initialization
	protected virtual void Start () {
        boxCollider = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
