using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour {

	public GameObject cube;

	// Update is called once per frame
	void Update () {

		cube.transform.position = cube.transform.position + new Vector3 (2, 0, 0);
		cube.transform.position = cube.transform.position + new Vector3 (0, 2, 0);
		//drag to reference itself
	}
}
