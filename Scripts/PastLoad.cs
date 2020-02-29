using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PastLoad : MonoBehaviour
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
			Destroy (GameObject.FindWithTag("Player"));
			Test = true;
			SceneManager.LoadScene("SampleScene");

		}
	}
}
