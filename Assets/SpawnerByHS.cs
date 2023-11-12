using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByHS : MonoBehaviour
{
    public GameObject enemy;
	public float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
	    Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;

        if (timer <=0){
            Instantiate(enemy, gameObject.transform.position, Quaternion.identity);
    
	        timer = 3;
        }

    }

}