using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {

	public GameObject gameLogic;
	public GameObject box;
	private GameLogic logicScript;
	private int screenIndex = 0;
	private ArrayList boxes;
	private float freebox = 1.3f;
	private const int NUMITEMS = 4;
	private int ITEMOFFSET = 0;

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

	public void setScreen(string t) {

		int lower = ITEMOFFSET * NUMITEMS;

		if (t == "Military") {
			clearScreen();
			screenIndex = 0;

			ArrayList military = logicScript.getMilitary();
			
			int upper = Mathf.Min(lower + NUMITEMS, military.Count);
			
			for (int i = lower; i < upper; i++) {
				Ship s = (Ship)military[i];
				boxes.Add (createFreeBox(s.getName()));
			}
		} else if (t == "Planets") {
			clearScreen();
			screenIndex = 1;

			ArrayList planets = logicScript.getPlanets();

			int upper = Mathf.Min(lower + NUMITEMS, planets.Count);

			for (int i = lower; i < upper; i++) {
				Planet p = (Planet)planets[i];
				boxes.Add (createFreeBox(p.getName()));
			}
		} else if (t == "Research") {
			clearScreen();
			screenIndex = 2;
			
			ArrayList research = logicScript.getResearch();
			
			int upper = Mathf.Min(lower + NUMITEMS, research.Count);
			
			for (int i = lower; i < upper; i++) {
				Research r = (Research)research[i];
				boxes.Add (createFreeBox(r.getName()));
			}
		} else if (t == "Resources") {
			clearScreen();
			screenIndex = 3;
			
			Hashtable resources = logicScript.getResources();
			
			int upper = Mathf.Min(lower + NUMITEMS, resources.Count);
			
			foreach (DictionaryEntry e in resources) {
				boxes.Add (createFreeBox((string)e.Key));
			}
		}

		Debug.Log("Name is: " + t + " and index is: " + screenIndex);
	}

	private GameObject createBox(string text, Vector3 position) {
		GameObject b = (GameObject)Instantiate(box);
		b.name = text;
		b.transform.position = position;
		return b;
	}

	public GameObject createFreeBox(string name) {
		// Will need name, image, value, description
		GameObject b = createBox(name, new Vector3(-1,freebox,1));
		freebox -= 0.85f;
		return b;
	}
}
