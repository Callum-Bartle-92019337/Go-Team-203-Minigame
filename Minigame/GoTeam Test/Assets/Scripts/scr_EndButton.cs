

/*
 *Script attached to the Start game button
 *
 * Goes to the game scene
 *
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class scr_EndButton : Singleton<scr_EndButton>
    {


        [SerializeField] private Button _myButton = null; // assign in the editor
        [SerializeField] private string _myLevelSting = null; // assign in the editor
        [SerializeField] public int Score;
      
        void Start()
        {
            Score = 75; // assign in the editor
            _myButton.onClick.AddListener(MyAction);
        }

        void MyAction()
        {
            //_score = 100;//Mathf.RoundToInt((parTime / TimePassed) * 100);
            //unlocks the level set in the inspector
            //PlayerPrefs.SetInt(_levelToUnlock, 1);
            //stores your score in the player prefs
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_score", Score);
            //Load the level select
            SceneManager.LoadScene(_myLevelSting);
        }
    }
}