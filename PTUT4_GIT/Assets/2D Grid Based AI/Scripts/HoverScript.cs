using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class HoverScript : MonoBehaviour {


    private SpriteRenderer spriteRenderer;
    private SpriteRenderer rangeSpriteRenderer;


    // Use this for initialization
    void Start () {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        //this.rangeSpriteRenderer = transform.getChild(0).getComponent<SpriteRenderer>();
	}

 

    // Update is called once per frame
    void Update () {
        FollowMouse();
	}

    public void FollowMouse()
    {
        if (spriteRenderer.enabled)
        {
            this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }

    public void Activate(Sprite sprite)
    {
        this.spriteRenderer.sprite = sprite;
        spriteRenderer.enabled = true;
        rangeSpriteRenderer.enabled = true;

    }
    public void Desactivate()
    {
        spriteRenderer.enabled = false;
        rangeSpriteRenderer.enabled = false;
    //    GameManager.Instance.ClickedBtn = null;
        
    }
}
