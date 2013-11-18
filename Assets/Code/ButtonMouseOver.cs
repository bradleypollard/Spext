using UnityEngine;
using System.Collections;

public class ButtonMouseOver : MonoBehaviour {

	private SpriteRenderer r;
	public Sprite mouseOff;
	public Sprite mouseOn;
	public GameObject overlay;
	public GameObject gameLogic;
	private Overlay overlayScript;
	private GameLogic logicScript;

	// Use this for initialization
	void Start () {
		r = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
	}

	void Update () {
		if (overlay != null && overlayScript == null) {
			overlayScript = (Overlay)overlay.GetComponent("Overlay");
		} else if (overlay == null) {
			logicScript = (GameLogic)gameLogic.GetComponent("GameLogic");
		}
	}

	void OnMouseOver() {
		r.sprite = mouseOn;
	}

	void OnMouseExit() {
		r.sprite = mouseOff;
	}

	void OnMouseDown() {
		if (overlayScript != null) {
			overlayScript.setScreen(gameObject.name);
		} else {
			logicScript.incrementDay();
		}
	}
}
