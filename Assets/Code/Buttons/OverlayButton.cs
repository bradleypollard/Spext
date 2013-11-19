using UnityEngine;
using System.Collections;

public class OverlayButton : ButtonMouseOver {

	public GameObject overlay;
	private Overlay overlayScript;

	// Use this for initialization
	void Start () {
		r = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
	}
	
	// Update is called once per frame
	void Update () {
		if (overlayScript == null) {
			overlayScript = (Overlay)overlay.GetComponent("Overlay");
		}
	}

	void OnMouseDown() {
		// TODO
		Debug.Log (name);
	}
}
