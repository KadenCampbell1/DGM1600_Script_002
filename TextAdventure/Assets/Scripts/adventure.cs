using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventure : MonoBehaviour 
{
    /*

        public enum Location { centerRoom, door, window, fireplace, items, photos, vase, statue};
        public Location myLocation;
        public int murderCount;
        private int gameOver = 1;
        private int key = 0;
        public int venusStatue = 0;
        //private int visitedFire = 0;
        private int visitedItems = 0;
        public bool visitedFire;


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
                            visitedFire = true;
                        }

                        //!visitedFire for false

                        if (visitedFire) 
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
                        if (murderCount <= 0) 
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

        */

    public enum Location { centerRoom, door, window, fireplace, items, photos, vase, statue, table, manila };
    public Location myLocation;
    public Text titleObject;
    public Text textObject;
    public bool gameOver;
    public int murderCount;
    public bool key;
    public bool venusStatue;
    public bool manila;
    public int locationSpriteNumber;
    //public Image background;
    public Background background;


    void Start()
    {
        CenterRoom();
    }

    private void CenterRoom()
    {
        myLocation = Location.centerRoom;

        background.emptyNumber = 0;
       // background.emptyNumber = 0;

        titleObject.text = "Center of the Room";
        textObject.text = "you are in the Center of a room. \n" +
            "There is a coffee Table in front of you.\n" +
            "Press T for the coffee Table";
        

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
    }


    private void Door()
    {
        background.emptyNumber = 1;

        if (key == false)
        {
            myLocation = Location.door;
            titleObject.text = "Door";
            if (manila == true)
            {
                textObject.text = "The Door is locked, it has a place for a key. \n" +
                    "It seems that someone is doing this to hurt you.\n" +
                    "You better burn the Manila envelope, so the murderer won't have leverage on you.\n" +
                    "Press F for Fireplace, T for the coffee Table, W for Window.";
            }
            else
            {
                textObject.text = "The Door is locked, it has a place for a key. \n" +
                    "It seems that someone is doing this to hurt you.\n" +
                    "Press W for Window, T for the coffee Table, F for Fireplace.";
            }
            
            if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
            if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
            if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
        }
      
        /*
        if (key == true)
        {
            gameOver = true;
        }
        */

        else
        {
            titleObject.text = "You've Escaped!";
            textObject.text = "You used the key to unlock the Door. \n" +
                "You have exited the living room and ran out the front door. \n" +
                "You get to the car and drive away. \n" +
                "You Win!";
            murderCount = 2;
        }
    }

    private void Window()
    {
        myLocation = Location.window;

        background.emptyNumber = 2;

        titleObject.text = "Window";
        textObject.text = "It is dark outside and it is raining hard.\n" +
            "Through the Window you can see a car...\n" +
            "It could be the murderer's.\n" +
            "Press T for the coffee Table, D for Door or F for Fireplace.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
    }

    private void Fireplace()
    {
        myLocation = Location.fireplace;

        background.emptyNumber = 3;

        titleObject.text = "Fireplace";
        if (manila == false)
        {
            textObject.text = "The fire is warm. \n" +
                "There is a Shelf with items above it.\n" +
                "Press T for the coffee Table, S for the Shelf, W for Window, or D for Door.";
        }
        else
        {
            textObject.text = "The fire is warm. You have burned the Manila envelope. \n" +
                "There is a Shelf with items above it.\n" +
                "Press T for the coffee Table, S for the Shelf, W for Window, or D for Door.";
        }

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.S)) { myLocation = Location.items; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }

        
    }

    private void Items()
    {
        myLocation = Location.items;

        background.emptyNumber = 4;

        titleObject.text = "Shelf";
        textObject.text = "You see family Photos, a Vase of flowers, and a Statue.\n" +
            "Press P for the Photos, V for the Vase, or S for the Statue.\n" +
            "Press T for the coffee Table, D for Door, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.P)) { myLocation = Location.photos; }
        if (Input.GetKeyDown(KeyCode.V)) { myLocation = Location.vase; }
        if (Input.GetKeyDown(KeyCode.S)) { myLocation = Location.statue; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }

        

    }

    private void Photos()
    {
        key = true;
        myLocation = Location.photos;

        background.emptyNumber = 5;

        titleObject.text = "Photo";
        textObject.text = "It is a nice looking family, but it is not yours. \n" +
            "There is a key taped to the back. (you now possess the key)\n" +
            "Press V for the Vase, or S for the Statue.\n" +
            "Press T for the coffee Table, D for Door, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.V)) { myLocation = Location.vase; }
        if (Input.GetKeyDown(KeyCode.S)) { myLocation = Location.statue; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
    }

    private void Vase()
    {
        myLocation = Location.vase;

        background.emptyNumber = 6;

        titleObject.text = "Vase";
        textObject.text = "A Vase of roses. They are very pretty.\n" +
            "Press P for the Photo, or S for the Statue.\n" +
            "Press T for the coffee Table, D for Door, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.P)) { myLocation = Location.photos; }
        if (Input.GetKeyDown(KeyCode.S)) { myLocation = Location.statue; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
    }

    private void Statue()
    {
        venusStatue = true;
        myLocation = Location.statue;

        background.emptyNumber = 7;

        titleObject.text = "Statue";
        textObject.text = "It is a miniature Statue of venus. \n" +
            "You can use this to attack the murderer.\n" +
            "Press P for the Photo, or V for the Vase.\n" +
            "Press T for the coffee Table, D for Door, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.P)) { myLocation = Location.photos; }
        if (Input.GetKeyDown(KeyCode.V)) { myLocation = Location.vase; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
    }

    private void Table()
    {
        myLocation = Location.table;

        background.emptyNumber = 8;

        titleObject.text = "Table";
        textObject.text = "It is a knee high coffee table made of oak. \n" +
            "There is a Manila envelope with pictures sticking out.\n" +
            "Press M for the Manila envelope.\n" +
            "Press D for Door, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.M)) { myLocation = Location.manila; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
    }

    private void Manila()
    {
        manila = true;
        myLocation = Location.manila;

        background.emptyNumber = 9;

        titleObject.text = "Manila Envelope";
        textObject.text = "It is a Manila envelope filed with pictures and documents that could be used to blackmail you.\n" +
            "You should take it and leave. (You now possess the Manila Envelope)\n" +
            "Press D for Door, T for the coffee Table, F for Fireplace, or W for the Window.";

        if (Input.GetKeyDown(KeyCode.T)) { myLocation = Location.table; }
        if (Input.GetKeyDown(KeyCode.D)) { myLocation = Location.door; }
        if (Input.GetKeyDown(KeyCode.F)) { myLocation = Location.fireplace; }
        if (Input.GetKeyDown(KeyCode.W)) { myLocation = Location.window; }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.M))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.T))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.D))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.F))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.P))
            {
                murderCount--;
            }

            else if (Input.GetKeyDown(KeyCode.V))
            {
                murderCount--;
            }

            if (murderCount == 0)
            {
                gameOver = true;
            }

            if (myLocation == Location.centerRoom)
            {
                CenterRoom();
            }

            else if (myLocation == Location.door)
            {
                Door();
            }

            else if (myLocation == Location.window)
            {
                Window();
            }

            else if (myLocation == Location.fireplace)
            {
                Fireplace();
            }

            else if (myLocation == Location.items)
            {
                Items();
            }

            else if (myLocation == Location.photos)
            {
                Photos();
            }

            else if (myLocation == Location.vase)
            {
                Vase();
            }

            else if (myLocation == Location.statue)
            {
                Statue();
            }
            else if (myLocation == Location.table)
            {
                Table();
            }
            else if (myLocation == Location.manila)
            {
                Manila();
            }

        }
        else if (gameOver == true)
        {
            if (venusStatue == false)
            {
                titleObject.text = "Game Over";
                textObject.text = "The murderer has entered the room. \n" +
                    "You are dead.";
            }

            else if (venusStatue == true)
            {
                titleObject.text = "You've Escaped!";
                textObject.text = "The murderer has entered the room, however you have the Venus Statue. \n" +
                    "You smash it over their head and get away.\n" +
                    "You Win!";
            }



            /*
            if (key == false)
            {
                titleObject.text = "Game Over";
                textObject.text = "The murderer has entered the room. \n" +
                    "You are dead.";
            }
            */
            /*
            else if (key == true)
            {
                titleObject.text = "You've Escaped!";
                textObject.text = "You used the key to unlock the Door. \n" +
                    "You have exited the living room and ran out the front door. \n" +
                    "You get to the car and drive away. \n" +
                    "You Win!";
            }
            */
        }
    }

}

