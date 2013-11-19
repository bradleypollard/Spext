using UnityEngine;
using System.Collections;

public class BoxButton : ButtonMouseOver {

	// Use this for initialization
	void Start () {
		r = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		// TODO
	}
}
