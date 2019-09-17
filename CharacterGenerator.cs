using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class contains functions for generating a CharacterSheet

public class CharacterGenerator : MonoBehaviour
{

    public RosterController OurRosterController; //The game's OurRosterController


    //void GenerateCharacter() creates a randomized CharacterSheet and stores the sheet in GlobalRoster using AddCharacterToGlobalRoster( , RosterController.GlobalRoster);
    void GenerateCharacter()
    {
        //Declare a new CharacterSheet
        CharacterSheet characterID = new CharacterSheet();

        //Fill the new CharacterSheet with data
        characterID.name = RandomName();  //set a character name
        characterID.OnMission = false; //by default, this is false
        characterID.Health = 100; //by deafult this is 100. It can be changed.

        //Add the character to GlobalRoster
        OurRosterController.AddCharacterToGlobalRoster( characterID, OurRosterController.GlobalRoster);

    }

    string RandomName()
    {
        List<string> FirstNames = new List<string>() {"John", "Ashley", "Cait", "Jarvin", "Seth", "Jenny", "Peach", "Sam"}; //replace with text doc of random names
        List<string> LastNames = new List<string>() {"Brown", "Smith", "Gonzales", "Fleur", "Nacht", "White", "Wu", "Park"}; //replace with text doc of random names

        //code for random name....... pull a 1st name and a 2nd name from
        return (FirstNames[Random.Range(1,8)] + " " + LastNames[Random.Range(1,8)]);
    }


}
