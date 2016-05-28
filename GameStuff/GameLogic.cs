using UnityEngine;
using System.Collections;

//The debug statements are meant to guide you through the functionality of the game.
//You can delete them later and replace them with other components wherever relevant (animations, images, etc.).
//Also, there are some things I didn't quite finish.  Any comments with the word "HERE" indicates that you have to complete
//a particular task in the area that that comment is located.
//I'm not sure if the Civilian and Enemy classes will be of any use to you, but I'll keep them here just in case.

//A tip for testing this out is to keep track of the debug messages "A civilian has appeared" and "The civilian is safe" in the
//console log.  Keep your eye on the "A civilian has appeared" count and wait for "The civilian is safe" count to match it.
//Once the counts match, you can go back to tapping P.

//Note: I didn't have enough time today to program the end of the game if a civilian is killed or the timer reaches 0.
//But finding the necessary method to do that shouldn't be hard.
public class GameLogic : MonoBehaviour
{

    private int playerScore;
    private int character;
    private float civTimer;

    void Start()
    {//initialization
        playerScore = 0;
        civTimer = 60;
        Debug.Log("The game has started");
        character = Random.Range(0, 100);
        spawnCharacter();
    }

    void OnGUI()
    {
        GUI.skin.label.fontSize = 30;
        GUI.Box(new Rect(10, 10, 50, 50), "Score");
        GUI.Label(new Rect(20, 25, 50, 50), playerScore.ToString("0"));
    }

    void Update()
    {
        if (character <= 10 && civTimer > 0)
            civTimer -= 1;//Since Update() is called every frame, decrement based on the above condition
        else if (character <= 10 && civTimer <= 0)
        {//indicates that the timer for a civilian has reached 0
         //get rid of the civilian image HERE.  A new character is produced afterwards.
            Debug.Log("The civilian is safe.");
            character = Random.Range(0, 100);
            spawnCharacter();
            civTimer = 200; //restart the civTimer for the next time a civilian comes
                            //civTimer does not decrement again unless character <= 10
        }

        if (Input.GetKeyDown(KeyCode.P))
        {//once P is pressed, you either lose the game or gain a point depending on the character on the screen
            //cue punch animation
            if (character <= 10)//if the character is a civilian
            {
                Debug.Log("Game over.  You killed a civilian.");
                //Google a method to terminate the ENTIRE game HERE.
                //Otherwise, the game timer will keep running when it shouldn't.
                //Also, prompt the player to return to the main menu.
            }
            else if (character > 10)//if the character is an enemy
            {
                //  get rid of the enemy image HERE
                //  cue explosion animation
                Debug.Log("You killed an enemy.");
                playerScore++;
            }
            
            //The game hasn't ended yet.  After gaining a point, a new character is produced.
            character = Random.Range(0, 100);
            spawnCharacter();
        }
    }

    void spawnCharacter()
    {
        if (character <= 10)
            Debug.Log("A civilian has appeared.");
        else if (character > 10 && character <= 100)
            Debug.Log("An enemy has appeared.");

        //produce a civilian or enemy image HERE depending on the value of character
    }
}
