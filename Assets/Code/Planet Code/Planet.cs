using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	private GameLogic logic;

	private string name;
	private int population = 0;
	private int type;
	private Hashtable resourcesGenerated;
	private Hashtable resourcesUsed;
	private ArrayList buildings;

	public Planet(string name, int type) {
		this.name = name;
		this.type = type;
	}

	// Use this for initialization
	void Start () {
		buildings = new ArrayList();
		resourcesGenerated = initResources();
		resourcesUsed = initResources();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private Hashtable initResources() {
		Hashtable r = new Hashtable();
		r.Add("Minerals", 0);
		r.Add("Gas",0);
		return r;
	}

	public void incrementPopulation() {
		population++;
	}

	// Create a new building
	public void buildBuilding(Building b) {
		if (logic.spendResources(b.getCost())) {
			buildings.Add(b);
		}
	}

	public string getName() {
		return name;
	}

	public int getPopulation() {
		return population;
	}

	public Hashtable getResources() {
		Hashtable ret = new Hashtable();

		foreach (DictionaryEntry r in resourcesGenerated) {
			ret.Add (r.Key, (int)resourcesGenerated[r.Key] - (int)r.Value);
		}

		return ret;
	}

	public Hashtable getResourcesGenerated() {
		return resourcesGenerated;
	}

	public Hashtable getResourcesUsed() {
		return resourcesUsed;
	}

	public void populate() {
		population++;
	}
}
