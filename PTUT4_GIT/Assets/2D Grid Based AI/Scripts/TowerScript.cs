using UnityEngine;
using System.Collections;

public class TowerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(transform.parent.gameObject);
        }

    }
}
