using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class XML : MonoBehaviour
{
    Player player = new Player();
    [SerializeField] TMP_InputField userName;
    [SerializeField] TMP_InputField race;
    [SerializeField] TMP_Dropdown characterClass;

    [SerializeField] TMP_InputField level;
    [SerializeField] Slider health;

    [SerializeField] GameObject NPF;

    void Start()
    {
        if(System.IO.File.Exists("player.xml")){
            Debug.Log("File Exists");
            player = XMLOp.Deserialize<Player>("player.xml");
            userName.text = player.userName;
            race.text = player.race;
            characterClass.value = player.characterClass;
            level.text = player.level.ToString();
            health.value = player.health;
        } else
        {
            NPF.SetActive(true);
            Debug.Log("File doesn't exist");
            userName.text = player.userName;
            race.text = player.race;
            characterClass.value = player.characterClass;
            level.text = player.level.ToString();
            health.value = player.health;

        }
    }

    // Update is called once per frame
    public void Save()
    {
        Debug.Log("Saving...");
        player.userName = userName.text;
        player.race = race.text;
        player.characterClass = characterClass.value;
        player.level = int.Parse( level.text);
        player.health = health.value;

        XMLOp.Serialize(player, "Player.xml");
        Debug.Log("Saved");
    }
}
