using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	private int day = 0;
	private int minerals = 0;
	private int research = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void incrementDay() {
		day++;
		Debug.Log("Day is: " + day);
	}
}
