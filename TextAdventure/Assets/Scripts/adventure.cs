using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adventure : MonoBehaviour 
{


    public enum Location { centerRoom, door, window, fireplace, items, photos, vase, statue};
    public Location myLocation;
	public int murderCount;
	private int gameOver = 1;
	private int key = 0;
	private int venusStatue = 0;
	private int visitedFire = 0;
	private int visitedItems = 0;


	// Use this for initialization
	void Start () 
	{
		murderCount += 1;
		CenterRoom ();
	}

	private void CenterRoom()
	{
		murderCount--;
		myLocation = Location.centerRoom;
		print ("you are in the Center of a room. you see a Window, a Door, and a Fireplace.");
	}

	private void Door()
	{
		murderCount--;
		myLocation = Location.door;
		print ("the Door is locked, it has a place for a key. it seems that someone is doing this to hurt you.");
	}

	private void Window()
	{
		murderCount--;
		myLocation = Location.window;
		print ("it is dark outside and it is raining hard. through the Window you can see a car... it could be the murderer's.");
	}

	private void Fireplace()
	{
		murderCount--;
		myLocation = Location.fireplace;
		print ("the fire is warm. there is a shelf with Items above it.");
	}

	private void Items()
	{
		murderCount--;
		myLocation = Location.items;
		print ("you see family Photos, a Vase of flowers, and a Statue.");
	}

	private void Photos()
	{
		key = 1;
		murderCount--;
		myLocation = Location.photos;
		print ("it is a nice looking family, but it is not yours. there is a key taped to the back. (you now possess the key)");
	}

	private void Vase()
	{
		murderCount--;
		myLocation = Location.vase;
		print ("a Vase of roses. they are very pretty.");
	}

	private void Statue()
	{
		venusStatue = 1;
		murderCount--;
		myLocation = Location.statue;
		print ("It is a miniature Statue of venus. you can use this to attack the murderer.");
	}


	// Update is called once per frame
	void Update () 
	{
		if (gameOver >= 1) 
		{
				if (murderCount > 0) 
				{
					if (Input.GetKeyDown (KeyCode.C)) 
					{
						CenterRoom ();
					}

					if (Input.GetKeyDown (KeyCode.D)) 
					{
						Door ();
						if (key >= 1) 
						{
							print ("you have exited the living room and ran out the front door to the car and get away. You Win.");
							gameOver = 0;
						}	
					}	

					if (Input.GetKeyDown (KeyCode.W)) 
					{
						Window ();
					}	

					if (Input.GetKeyDown (KeyCode.F))
					{
						Fireplace ();
						visitedFire = 1;
					}
					if (visitedFire >= 1) 
					{
						if (Input.GetKeyDown (KeyCode.I)) 
						{
							Items ();
							visitedItems = 1; 
						}
					if (visitedItems >= 1) 
					{
						if (Input.GetKeyDown (KeyCode.P)) 
						{
							Photos ();
						}	

						if (Input.GetKeyDown (KeyCode.V)) 
						{
							Vase ();
						}	

						if (Input.GetKeyDown (KeyCode.S)) 
						{
							Statue ();
						}
					}

					}
					else if (murderCount <= 0) 
					{
						if (venusStatue <= 0) 
						{
							print ("The murderer has entered the room. You are dead.");
							gameOver = 0;
						} 
						else if (venusStatue >= 1) 
						{
							print ("The murderer has entered the room, however you have the Venus Statue. You smash it over their head and get away.");
							gameOver = 0;
						}
					}

				}
			} 

		else if (gameOver <=0)
		{
			print("Your game is over.");
		}
			



	}

		
}

