using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {

	private string shipName;
	private int maxHealth;
	private int health;
	private int damage;

	public Ship(string name) {
		this.shipName = name;
	}

	// Use this for initialization
	void Start () {
		if (shipName == "Fighter") {
			maxHealth = 100;
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

	public string getName() {
		return name; 
	}

	public int getMaxHealth() {
		return maxHealth;
	}

	public int getHealth() {
		return health;
	}

	public int getDamage() {
		return damage;
	}

}
