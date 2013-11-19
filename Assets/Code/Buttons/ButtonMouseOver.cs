using UnityEngine;
using System.Collections;

public class ButtonMouseOver : MonoBehaviour {

	protected SpriteRenderer r;
	public Sprite mouseOff;
	public Sprite mouseOn;

	// Use this for initialization
	void Start () {
		r = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
	}

	// Update is called once per frame
	void Update () {

	}

	// When mouse enters button
	void OnMouseOver() {
		r.sprite = this.mouseOn;
	}

	// When mouse leaves button
	void OnMouseExit() {
		r.sprite = this.mouseOff;
	}

	// Leave implementation till later
	void OnMouseDown() {
		// Do nothing
	}
}
