using UnityEngine;
using System.Collections;

public class TurnToWall : MonoBehaviour {

	public GameManager Game;
	// Use this for initialization
	void Start () {
	

	}

	 bool isWall;
	void OnMouseDown()
	{
		string [] splitter = this.gameObject.name.Split (',');
		if(!Game.grid[int.Parse(splitter[0]), int.Parse(splitter[1])].IsWall)
		{
			Game.addWall(int.Parse(splitter[0]),int.Parse(splitter[1]));
		}
		else
		{
			Game.removeWall(int.Parse(splitter[0]),int.Parse(splitter[1]));
		}
		

	}


	// Update is called once per frame
	void Update () {
	
	}

}
