using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	// Start is called before the first frame update

 public float walkSpeed;
    
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		GameObject player = GameObject.Find("Player");
		
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position ,walkSpeed * Time.deltaTime);
		
	}
	
	
	// This function is called when the MonoBehaviour will be destroyed.
	protected void OnDestroy()
	{
		GameObject.Find("GameManager").GetComponent<GameManager>().playerScore(1);
	}
}