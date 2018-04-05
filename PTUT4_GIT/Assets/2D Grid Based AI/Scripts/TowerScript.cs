using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TowerScript : MonoBehaviour {

    private SpriteRenderer mySpriteRenderer;
    public GameObject enemy;
    public GameManager game;
    public float range = 5.0f;
    // Use this for initialization
    void Start () {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(game.enemies.Count);
        //foreach (GameObject ennemi in game.enemies)
        //{

        //    if (Vector3.Distance(ennemi.transform.position, transform.position) <= range)
        //    {
        //        Debug.Log(game.enemies.Count);
        //    }
        //}
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
