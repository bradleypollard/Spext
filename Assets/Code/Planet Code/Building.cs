using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour {
	
	private string name;
	private Hashtable cost = new Hashtable();
	private int resources;
	private int upkeep;
	private ArrayList production;

	public Building(string name) {
		this.name = name;
	}

	// Use this for initialization
	void Start () {
		if (name == "Hangar") {
			production.Add (new Ship("Fighter"));
			resources = 0;
			upkeep = 50;
			cost.Add ("Minerals",100);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Start production of something this building can make
	public void produce(string name) {
		if (production.Contains(name)) {
			// TODO
			Debug.Log ("Producing a " + name);
		}
	}

	public string getName() {
		return name;
	}

	public Hashtable getCost() {
		return cost;
	}

	public int getResources() {
		return resources;
	}

	public int getUpkeep() {
		return upkeep;
	}

	public ArrayList getProduction() {
		return production;
	}
}
