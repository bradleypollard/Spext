using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	private string shipName {get;set;}
	private int health {get;set;}
	private int damage {get;set;}

	public Ship(string name) {
		this.shipName = name;
	}

	// Use this for initialization
	void Start () {
		if (shipName == "Fighter") {
			health = 100;
			damage = 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Take damage during combat
	public void takeDamage(int d) {
		health = Mathf.Max (d, 0);

		if (health == 0) {
			// TODO
			Debug.Log("Dead!");
		}
	}

	// Deal damage in combat
	public void dealDamage(Ship target) {
		target.takeDamage(damage);
	}
}
