using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnityEngine;

public class HeroQuestManager : MonoBehaviour
{
    object[] array = new object[5];
    List<String> languages= new List<String>();
    Dictionary<String,String> Quests = new Dictionary<String,String>();

    // Start is called before the first frame update

        object Banana = new object();
                object Axe = new object();
                        object Healing = new object();
                                object Onion = new object();
                                        object Cloth = new object();
    void Start()
    {
        //Intialize Array with Items
        //Array is an Inventory 
        array[0] = Banana;
              array[0] = Axe;
                    array[0] = Healing;
                          array[0] = Onion;
                                array[0] = Cloth;

        //Intialize List with Language
        //List is a list of known Languages
        languages.Add("Common");
        //Dictionary is a Set of Quests
        Quests.Add("TavernKeep Joe","Hunt the Rats in the Basement");
        Quests.Add("BillyBob","Please find my Orb");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
