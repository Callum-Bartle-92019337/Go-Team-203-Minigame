

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
    public class scr_NavButton : MonoBehaviour
    {


        [SerializeField] private Button _myButton = null; // assign in the editor
        [SerializeField] private string _myLevelSting = null; // assign in the editor

        void Start()
        {
            _myButton.onClick.AddListener(MyAction);
        }
        
        void MyAction()
        {
            SceneManager.LoadScene(_myLevelSting);
        }
    }
}