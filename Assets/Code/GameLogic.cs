using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	private int day = 1;
	private Hashtable resources;
	private int research = 0;
	private ArrayList ownedPlanets;
	private ArrayList discoveredPlanets;

	// Use this for initialization
	void Start () {
		ownedPlanets = new ArrayList();
		resources = new Hashtable();
		resources.Add ("Minerals", 100);
		resources.Add ("Gas", 50);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Advance time
	public void incrementDay() {
		day++;
		Debug.Log("Day is: " + day);
	}

	// Spend money
	public bool spendResources(Hashtable costs) {
		// Check you have enough of all resources
		foreach (DictionaryEntry cost in costs) {
			if ((int)resources[cost.Key] < (int)cost.Value) {
				Debug.Log ("Not enough " + cost.Key);
				return false;
			}
		}

		// Then subtract cost
		foreach (DictionaryEntry cost in costs) {
			resources[cost.Key] = (int)resources[cost.Key] - (int)cost.Value;
		}

		return true;
	}

	public void addPlanet(Planet p) {
		ownedPlanets.Add(p);
	}

	public void discoverPlanet(Planet p) {
		discoveredPlanets.Add(p);
	}
}
