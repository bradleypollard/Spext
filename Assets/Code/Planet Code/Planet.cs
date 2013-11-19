using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	private GameLogic logic;

	private string name;
	private int population = 0;
	private int type = 0;
	private int resourcesGenerated = 100;
	private int resourcesUsed = 50;
	private ArrayList buildings;

	// Use this for initialization
	void Start () {
		buildings = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
