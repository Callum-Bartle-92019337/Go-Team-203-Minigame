

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
    public class scr_WrongButton : MonoBehaviour
    {


        private Button _myButton = null; // assign in the editor

        void Start()
        {
            _myButton = gameObject.GetComponent<Button>();
            
            _myButton.onClick.AddListener(MyAction);
        }
        
        void MyAction()
        {
            scr_EndButton.Instance.Score -= 5;
        }
    }
}