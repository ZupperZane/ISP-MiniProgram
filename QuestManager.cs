using System.Collections.Generic;
using UnityEngine;

public class HeroQuestManager : MonoBehaviour
{
    // 1. Player status
    public int PlayerLives = 3;
    public int PlayerGold = 20;

    void Start()
    {
        SetupParty();
        ShowDungeonRooms();
        ShowShopInventory();
        RunQuest();
    }

    // 2. Collections you must use:
    //    - An array of dungeon room names
    //    - A List<string> for party members
    //    - A Dictionary<string, int> for item prices

    string[] dungeonRooms;
    List<string> QuestPartyMembers;
    Dictionary<string, int> ItemInventory;

    void SetupParty()
    {
        // TODO: (List)
        //Intialization
        // 1. Create the QuestPartyMembers list and initialize it 
        //    with at least 3 party member names (strings).
        QuestPartyMembers = new List<string>(){
            "Bobby", "Tommy", "Billy"
        };
        //Adding Members via .Add
        // 2. Add at least 1 more member using Add().
        QuestPartyMembers.Add("Robby");
        // 3. Remove at least 1 member using RemoveAt() or Remove().
        QuestPartyMembers.RemoveAt(2);
        //Removed Billy

        // 4. Use a for loop to print every party member with its index.
        //    Example log format: "Party Index 0 - Merlin the Wise"
        for (int i = 0; i < QuestPartyMembers.Count; i++)
        {
            Debug.Log($"{QuestPartyMembers[i]}");
        }
    }

    void ShowDungeonRooms()
    {
        // TODO: (Array + for loop)
        // 1. Create a string array called dungeonRooms with at least 4 room names,
        //    for example: "Entrance", "Spike Hall", "Treasure Vault", "Dragon Lair".
        dungeonRooms = new string[] { "Hall of Oaths", "Deathpit Cavern", "Chicago" };
        // 2. Store that array in the field dungeonRooms.
  
        // 3. Use a for loop to print each room with its index.
        //    Example log format: "Room 0 - Entrance"
        for (int i = 0; i < dungeonRooms.Length; i++)
        {
            Debug.Log($"{dungeonRooms[i]}");
        }
    }
        void ShowShopInventory()
        {
        // TODO: (Dictionary + foreach)
        // 1. Create a Dictionary<string, int> called ItemInventory 
        //    where the key is the item name and the value is the cost in gold.
        //    Example items: "Potion" (5g), "Antidote" (7g), "Elixir" (10g).
        // 2. Assign it to the ItemInventory field.
        ItemInventory = new Dictionary<string, int>()
            {
                { "Goblet", 5 },
                { "Cloak", 12 },
                { "Chicken", 4 },
            };

            // 3. Use a foreach loop with KeyValuePair<string, int> to print each item:
            //    Example: "Shop Item: Potion - 5g"
            foreach (var i in ItemInventory)
            {
                Debug.Log($"Shop Item: {i.Key} -{i.Value}g ");
                if (i.Value < PlayerGold)
                {
                    Debug.Log($"You can afford {i.Key}.");
                }
            }
            // 4. Inside the same foreach loop, add an if statement that prints an extra log
            //    ONLY for items the player can afford with PlayerGold.
            //    Example: "You can afford Potion!"
            //    (Hint: compare PlayerGold with kvp.Value.)
        }

        void RunQuest()
        {
        // TODO: (while + collections)
        // Simulate the hero moving through each dungeon room while they are alive.
        // 1. Create a local int index variable called roomIndex and set it to 0.
        int localRoomindex = 0;
        // 2. Write a while loop that runs as long as:
        //    - PlayerLives > 0 AND
        //    - roomIndex is less than dungeonRooms.Length
        //
        //    while (PlayerLives > 0 && roomIndex < dungeonRooms.Length)
        //    {
        //        ...
        //    }
        while (PlayerLives > 0 && localRoomindex < dungeonRooms.Length)
        {
            // 3. Inside the while loop:
            //    a) Log which room the player has entered using dungeonRooms[roomIndex].
            //       Example: "Entering room: Spike Hall"
            //
            Debug.Log($"Entering room: {dungeonRooms[localRoomindex]}");
            //    b) Use a foreach loop over QuestPartyMembers to print a "roll call":
            //       Example: "Grim the Barbarian is ready!"
            //
            foreach (var member in QuestPartyMembers)
            {
                Debug.Log($"{member} is Ready!");
            }
            //    c) Simulate something dangerous happening in each room:
            //       - Decrease PlayerLives by 1
            //       - Log the new number of lives: "Still alive! Lives left: 2"
            //
            PlayerLives = PlayerLives - 0;
            Debug.Log($"{dungeonRooms[localRoomindex]} entered,Lives left: {PlayerLives}");
            //    d) Increase roomIndex by 1 at the end of the loop.
            //       (roomIndex++)
            //
            localRoomindex++;
        }

        // 4. After the while loop finishes, log one of the following messages:
        //    - If PlayerLives <= 0, log: "Player KO'd before finishing the dungeon."
        //    - Else (if all rooms were cleared), log: "Player cleared all rooms!"
        if(PlayerLives<= 0)
        {
            Debug.Log("Player Ko'd before finishing the dungeon");

        }
        else {
            Debug.Log("Player Cleared all Rooms!");
        }

    }
    }

