using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TowerScript : MonoBehaviour {

    private SpriteRenderer mySpriteRenderer;
    public GameObject enemy;
    // Use this for initialization
    void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
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

    //pas encore utiliser
    public void Select()
    {
        mySpriteRenderer.enabled = !mySpriteRenderer.enabled;
    }
    public void OnTrigger2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
          //  enemy = other.GetComponent<Enemy>();
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            enemy = null;
        }
    }
}
