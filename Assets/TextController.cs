using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
                         stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet, corridor_2,
                         stairs_2, corridor_3, courtyard};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {

        print(myState);

        if      (myState == States.cell)                    {cell();}
        else if (myState == States.sheets_0)                {sheets_0();}
        else if (myState == States.mirror)                  {mirror();}
        else if (myState == States.lock_0)                  {lock_0();}
        else if (myState == States.cell_mirror)             {cell_mirror();}
        else if (myState == States.sheets_1)                {sheets_1();}
        else if (myState == States.lock_1)                  {lock_1();}
        else if (myState == States.corridor_0)              {corridor_0();}
        else if (myState == States.stairs_0)                {stairs_0();}
        else if (myState == States.floor)                   {floor();}
        else if (myState == States.closet_door)             {closet_door();}
        else if (myState == States.corridor_1)              {corridor_1();}
        else if (myState == States.stairs_1)                {stairs_1();}
        else if (myState == States.in_closet)               {in_closet();}
        else if (myState == States.corridor_2)              {corridor_2();}
        else if (myState == States.stairs_2)                {stairs_2();}
        else if (myState == States.corridor_3)              {corridor_3();}
        else if (myState == States.courtyard)               {courtyard();}

    }

    #region State handler methods
    void cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to view Sheets, M to view mirror, L to view Lock ";

        if (Input.GetKeyDown(KeyCode.S))                    {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M))               {myState = States.mirror;}
        else if (Input.GetKeyDown(KeyCode.L))               {myState = States.lock_0;}

    }

    void sheets_0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time someone changed them.The pleasures of prison life " +
                    "I guess.\n\n" +
                    "Press R to Return to roaming round your cell ";

        if (Input.GetKeyDown(KeyCode.R))                    {myState = States.cell;}

    }

    void mirror()
    {
        text.text = "You look at your reflection. You've changed; you look " +
                    "old. Gonna need some real work once you get out of here." +
                    "The mirror might come in handy. \n\n" +
                    "Press R to Return to roaming round your cell or T to Take the mirror";

        if (Input.GetKeyDown(KeyCode.R))                    {myState = States.cell;}
        else if(Input.GetKeyDown(KeyCode.T))                {myState = States.cell_mirror;}

    }

    void lock_0()
    {
        text.text = "The lock looks pretty sturdy. It's an old-fashioned model, " +
                    "one that requires a specific key. You're gonna need something " +
                    "to jimmy it.\n\n" +
                    "Press R to Return to roaming round your cell ";

        if (Input.GetKeyDown(KeyCode.R))                    {myState = States.cell;}

    }

    void cell_mirror()
    {
        text.text = "You are now holding a mirror and standing in your room. " +
                    "Has your life ever looked more desperate? Your sheets are " +
                    "lying in a bunch on your bed, there's some *ahem* interesting " +
                    "writing where the mirror used to be and the door is still locked. \n\n " +
                    "Press S to view Sheets once again or L to view Lock ";

        if (Input.GetKeyDown(KeyCode.S))                    {myState = States.sheets_1;}
        else if (Input.GetKeyDown(KeyCode.L))               {myState = States.lock_1;}

    }

    void sheets_1()
    {
        text.text = "The sheets are still dirty. You're definitely going " +
                    "to catch something sooner or later. If you had a window " +
                    "(which you don't) you could definitely use the sheets to Rapunzel out.\n\n" +
                    "Press R to Return to roaming round your cell ";

        if (Input.GetKeyDown(KeyCode.R))                    {myState = States.cell_mirror;}

    }

    void lock_1()
    {
        text.text = "You break the mirror. Looks like you can use a glass shard to pick the lock. " +
                    "You carefully take a shard and start jimmying the lock, trying not to cut yourself " +
                    "in the process. That would be one way to die. You hear that satisfying click and " +
                    "and the door swings open a little. You stand up. Onwards to freedom!\n\n" +
                    "Press R to Return to misery (your cell) or O to Open the door ";

        if      (Input.GetKeyDown(KeyCode.R))               {myState = States.cell_mirror;}
        else if (Input.GetKeyDown(KeyCode.O))               {myState = States.corridor_0;}

    }

    void corridor_0()
    {
        text.text = "You've cleared the first hurdle. What, did you think it was going " +
                    "to be easy?? You are now standing in a dingy corridor. To your left " +
                    "are some stairs; to your right is a closet. You also notice something " +
                    "small on the floor.\n\n" +
                    "Press S to take the Stairs, C to view the Closet and F to investigate the Floor ";

        if      (Input.GetKeyDown(KeyCode.S))                    {myState = States.stairs_0;}
        else if (Input.GetKeyDown(KeyCode.C))                    {myState = States.closet_door; }
        else if (Input.GetKeyDown(KeyCode.F))                    {myState = States.floor; }

    }

    void stairs_0()
    {
        text.text = "You quietly take the stairs one step at a time. You reach the bottom of the stairs " +
                    "just as a sweatdrop rolls down your forehead. You see a small, unobtrusive door with " +
                    "a high tech lock. You realise this door holds some dangerous world-changing secret. " +
                    "You blink. You're no hero and would rather live a free, untroubled existence. Let's leave " +
                    "the secret busting for now. \n" +
                    "Press R to Return to the corridor upstairs";

        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_0; }
        
    }

    void closet_door()
    {
        text.text = "This closet might have some useful escape tools. Too bad it's locked.\n\n" +
                    "Press R to Return to the corridor";

        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_0; }

    }

    void floor()
    {
        text.text = "You bend down and examine the object on the floor; looks like it's a " +
                    "hairpin. How it managed to get there is indeed an intriguing question, but " +
                    "one that doesn't need solving right now. \n\n" +
                    "Press H to take the Hairpin or R to Return to the corridor";

        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.H))                   { myState = States.corridor_1; }
    }

    void corridor_1()
    {
        text.text = "You're feeling boistered by that invaluable hairpin in your pocket. " +
                    "There is another staircase that seems to be leading up and that closet " +
                    "seems to be giving you the evil eye. Luckily, it seems you picked up the " +
                    "invaluable skill of  lockpicking. Dem streets tot u rit!\n\n" +
                    "Press S to take the Stairs or P to Pick the closet lock";

        if      (Input.GetKeyDown(KeyCode.S))                   { myState = States.stairs_1; }
        else if (Input.GetKeyDown(KeyCode.P))                   { myState = States.in_closet; }

    }

    void stairs_1()
    {
        text.text = "You climb the stairs with a rising sense of urgency. How long are you going " +
                    "to keep taking side-tours? Before long, you find yourself on the roof. You " +
                    "walk towards the edge and peer down. You suddenly feel dizzy and step back. " +
                    "It's then you notice someone staring at you. He turns round and continues his " +
                    "solemn walk towards the edge. You bow your head and turn around. \n" +
                    "Press R to Return to the corridor and leave the man in peace";

        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_1; }

    }

    void in_closet()
    {
        text.text = "You pick the lock with ease. You quickly glance left and right before pulling " +
                    "the door open. Inside are sorry excuses for cleaning supplies and a janitor's " +
                    "outfit. The eerie silence makes you feel as though you're being watched. " +
                    "The voices seem to confirm that suspicion. \n\n" +
                    "Press D to play Dress up or R to Return to the corridor if that feels like a great sin to you";

        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_2; }
        else if (Input.GetKeyDown(KeyCode.D))                   { myState = States.corridor_3; }

    }

    void corridor_2()
    {
        text.text = "You're back to standing in the corridor only now the closet door is open " +
                    "and those stairs leading down are giving you an ominous feeling.\n\n" +
                    "Press S to take the Stairs (why?) or B to go Back and take another look at the closet";

        if      (Input.GetKeyDown(KeyCode.S))                   { myState = States.stairs_2; }
        else if (Input.GetKeyDown(KeyCode.B))                   { myState = States.in_closet; }

    }

    void stairs_2()
    {
        text.text = "You quickly run down the stairs; you feel more courageous now. To hell " +
                    "with the government and their billions! The people need to know! You slow " +
                    "down a little as you approach the door. Exposing this secret will change " +
                    "the world. Probably not right away, maybe not ever. And for what??" +
                    "...You glance at the door; you could've sworn it was mocking you.\n\n" +
                    "Press R to Return to the corridor upstairs";
        
        if      (Input.GetKeyDown(KeyCode.R))                   { myState = States.corridor_2; }

    }

    void corridor_3()
    {
        text.text = "You are now dressed as a janitor. You're so close you can feel it! " +
                    "You can hear sounds up ahead coming from the central courtyard. \n\n" +
                    "Press U to Undress (who am I to play at this charade?) or S to take the Stairs to the courtyard";

        if      (Input.GetKeyDown(KeyCode.U))                   { myState = States.in_closet; }
        else if (Input.GetKeyDown(KeyCode.S))                   { myState = States.courtyard; }

    }

    void courtyard()
    {
        text.text = "You see another janitor ahead; heart beating fast, you keep your head " +
                    "down and continue walking straight, making for the door. You push open " +
                    "the main gate and are immediately assualted by warm, blinding sunlight. " +
                    "You notice someone out of the corner of your eye. They look...tasty. " +
                    "A smile starts tugging at the corners of your mouth...\n\n" +
                    "Press P to play again";

        if      (Input.GetKeyDown(KeyCode.P))                   { myState = States.cell; }

    }
    #endregion


}
