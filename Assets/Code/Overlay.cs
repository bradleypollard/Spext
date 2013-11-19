using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {

	public GameObject gameLogic;
	public GameObject box;
	private GameLogic logicScript;
	private int screenIndex = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (logicScript == null) {
			logicScript = (GameLogic)gameLogic.GetComponent("GameLogic");
		}
	}

	public void setScreen(string s) {
		if (s == "Military") {
			screenIndex = 0;
		} else if (s == "Planets") {
			screenIndex = 1;
		} else if (s == "Research") {
			screenIndex = 2;
		} else if (s == "Resources") {
			screenIndex = 3;
		}

		Debug.Log("Name is: " + s + " and index is: " + screenIndex);
	}

	public void createBox(string text) {
		GameObject b = (GameObject)Instantiate(box);
		b.transform.position = new Vector3(1,1,1);
	}
}
