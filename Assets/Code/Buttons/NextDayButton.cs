using UnityEngine;
using System.Collections;

public class NextDayButton : ButtonMouseOver {

	public GameObject gameLogic;
	private GameLogic logicScript;
	
	// Use this for initialization
	void Start () {
		r = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
	}
	
	// Update is called once per frame
	void Update () {
		if (logicScript == null) {
			logicScript = (GameLogic)gameLogic.GetComponent("GameLogic");
		}
	}

	void OnMouseDown() {
		logicScript.incrementDay();
	}
}
