
/*
 *Script attached to the delete saves button
 *
 * Clears the player prefs and resets the scene
 *
 */
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Level_Select
{
    public class scr_DeleteSaveButton : MonoBehaviour
    {


        [SerializeField] private Button _myButton = null; // assign in the editor

        void Start()
        {
            _myButton.onClick.AddListener(DeleteAllSaves);
        }

        // Update is called once per frame
        void DeleteAllSaves()
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene("Level Select");
        }
    }
}