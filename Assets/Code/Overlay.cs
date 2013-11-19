using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {

	public GameObject gameLogic;
	public GameObject box;
	private GameLogic logicScript;
	private int screenIndex = 0;
	private ArrayList boxes;
	private float freebox = 1.3f;

	// Use this for initialization
	void Start () {
		boxes = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
		if (logicScript == null) {
			logicScript = (GameLogic)gameLogic.GetComponent("GameLogic");
		}
	}

	public void clearScreen() {
		foreach (GameObject o in boxes) {
			Destroy(o);
		}

		boxes = new ArrayList();
		freebox = 1.3f;
	}

	public void setScreen(string s) {
		if (s == "Military") {
			clearScreen();
			screenIndex = 0;

			boxes.Add (createFreeBox("Ship A"));
			boxes.Add (createFreeBox("Ship B"));
			boxes.Add (createFreeBox("Ship C"));
			boxes.Add ((GameObject)createFreeBox("Ship D"));
		} else if (s == "Planets") {
			clearScreen();
			screenIndex = 1;
			
			boxes.Add (createFreeBox("Planet A"));
			boxes.Add (createFreeBox("Planet B"));
		} else if (s == "Research") {
			clearScreen();
			screenIndex = 2;
			
			boxes.Add (createFreeBox("Research A"));
			boxes.Add (createFreeBox("Research B"));
			boxes.Add (createFreeBox("Research C"));
		} else if (s == "Resources") {
			clearScreen();
			screenIndex = 3;
			
			boxes.Add (createFreeBox("Minerals"));
			boxes.Add (createFreeBox("Gas"));
			boxes.Add (createFreeBox("Power"));
			boxes.Add (createFreeBox("Research"));
		}

		Debug.Log("Name is: " + s + " and index is: " + screenIndex);
	}

	private GameObject createBox(string text, Vector3 position) {
		GameObject b = (GameObject)Instantiate(box);
		b.name = text;
		b.transform.position = position;
		return b;
	}

	public GameObject createFreeBox(string name) {
		GameObject b = createBox(name, new Vector3(-1,freebox,1));
		freebox -= 0.85f;
		return b;
	}
}
