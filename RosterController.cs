using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class manages the game's rosters.
//This class will...

public class RosterController : MonoBehaviour
{

    public static RosterController instance; //use instance to access self
    private List<Roster> GameRosters = new List<Roster>(); //This list of rosters is used to track existing rosters.

    public CharacterSheet testSheet; //test charSheet variable

    //Create a GlobalRoster and PlayerRoster
    Roster GlobalRoster = new Roster();
    Roster PlayerRoster = new Roster();

    void Start ()
    {
        //Load saved roster, if no roaster to load return null
        //if yes, store the loaded roster in Global/PlayerRoster
        //LoadGlobalRoster();

        //At start of the game, add Global and Player rosters to GameRosters

        GameRosters.Add(GlobalRoster);
        GameRosters.Add(PlayerRoster);

        //CreateRoster("GlobalRoster");
        //CreateRoster("PlayerRoster");
    }


    void Update ()
    {
        /*if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space pressed");
            AddCharacterToGlobalRoster(testSheet, GlobalRoster);
            Debug.Log("adding " + GlobalRoster.TheRoster[0].Name);
            Debug.Log("adding " + GlobalRoster.TheRoster[1].Name);
        }*/ //CHECKS IF GLOBALROSTER IS WORKING
    }



    //Adds a CharacterSheet to the GlobalRoster
    void AddCharacterToGlobalRoster(CharacterSheet characterName,  Roster GlobalRoster)
    {
        GlobalRoster.TheRoster.Add(characterName);
    }


    //Adds a CharacterSheet to the PlayerRoster
    void AddCharacterToPlayerRoster(CharacterSheet characterName,  Roster PlayerRoster)
    {
        PlayerRoster.TheRoster.Add(characterName);
    }














    /*void CreateRoster(Roster name)
    {
        Roster name = new Roster();
        GameRosters.Add(name);
        Debug.Log("Added " + name + " to  GameRosters");
    }*/






    //void LoadGlobalRoster(filepath){}

}
