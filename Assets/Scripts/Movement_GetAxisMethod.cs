using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement_GetAxisMethod : MonoBehaviour {

    float speed;

	//public float health = 50f;

    // Use this for initialization
    void Start () {

        speed = 10f;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);

	/*	if (health <= 0f) 
		{
			Die ();
		}*/
	}
		
	public void TakeDamage (float amount)
	{
		//health -= amount;

	}

	// public void Die () 
	//{
		//Destroy (gameObject);
	//	SceneManager.LoadScene ("TestLevel");
}

