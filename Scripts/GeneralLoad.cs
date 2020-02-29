using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralLoad : MonoBehaviour
{
	public bool Test;
	public string Scene_Name;

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

			SceneManager.LoadScene(Scene_Name);

		}
	}
}
