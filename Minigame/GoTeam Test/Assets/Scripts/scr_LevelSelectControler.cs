/*
 * Script from unity assets
 * Manages the menu screen
 * 
 */

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class scr_LevelSelectControler : MonoBehaviour
    {

        [System.Serializable]//Stores the info for each button
        public class Level
        {
            public string levelText;
            public int unlocked;
            public bool inInteractable;
        }
        public GameObject loadingScreen; //Stores the loading screen to toggle
        public GameObject button; //Stores the button prefab
        public Transform spacer; //Stores the spacer to place the buttons in
        public List<Level> levelList; //Stores the list of buttons

        void Start()
        {
            //Unlocks the cursor when the room starts
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            //Makes the buttons when room starts
            FillList();
        }

        //function to make the buttons
        void FillList()
        {
            foreach (var l in levelList)
            {
                GameObject newButton = Instantiate(button);
                scr_LevelButton levelButton = newButton.GetComponent<scr_LevelButton>();
                levelButton.labelText.text = l.levelText;

                if (PlayerPrefs.GetInt("Level " + levelButton.labelText.text) == 1)
                {
                    l.unlocked = 1;
                    l.inInteractable = true;
                }
                levelButton.unlocked = l.unlocked;
                Button btnComponent = levelButton.GetComponent<Button>();
                btnComponent.interactable = l.inInteractable;
                btnComponent.onClick.AddListener(() => LoadLevels("Level " + levelButton.labelText.text));

                //Gets the score from this level from the player prefs
                int score = PlayerPrefs.GetInt(("Level " + levelButton.labelText.text + "_score"));
                if (score >= 25)
                {
                    levelButton.tick1.SetActive(true);
                }

                if (score >= 50)
                {
                    levelButton.tick2.SetActive(true);
                }

                if (score == 75)
                {
                    levelButton.tick3.SetActive(true);
                }

                newButton.transform.SetParent(spacer, false);
            }
            SaveAll();

        }

        // Saves the button stats to player prefs
        void SaveAll()
        {

            GameObject[] allButtons = GameObject.FindGameObjectsWithTag("LevelButton");
            foreach (GameObject buttons in allButtons)
            {
                scr_LevelButton tempButton = buttons.GetComponent<scr_LevelButton>();
                PlayerPrefs.SetInt("Level " + tempButton.labelText.text, tempButton.unlocked);
            }

        }

        //Function to load the scene from the level button and toggle load screen
        void LoadLevels(string value)
        {
            loadingScreen.SetActive(true);
            SceneManager.LoadScene(value);
        }
    }
}
