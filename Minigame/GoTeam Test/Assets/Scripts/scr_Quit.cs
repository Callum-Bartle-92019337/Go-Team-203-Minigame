using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scr_Quit : MonoBehaviour
{
    [SerializeField] private Button _myButton = null; // assign in the editor
    // Start is called before the first frame update
    void Start()
    {
        _myButton.onClick.AddListener(MyAction);
    }

    // Update is called once per frame
    void MyAction()
    {
        Application.Quit();
    }
}
