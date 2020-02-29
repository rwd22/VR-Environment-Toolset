using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FutureLoad3 : MonoBehaviour
{
	public bool Test;

    // Start is called before the first frame update
    void Start()
    {
		Test = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Controller")
		{
			Test = true;
			Destroy (GameObject.FindWithTag("Player"));

			SceneManager.LoadScene("Scene_3_Future");

		}
	}
}
