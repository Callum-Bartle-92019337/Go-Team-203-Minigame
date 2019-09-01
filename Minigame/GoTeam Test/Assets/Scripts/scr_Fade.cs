using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scr_Fade : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup = null;
    [SerializeField] private Button _myButton = null; // assign in the editor
    [SerializeField] private GameObject _disableObject = null;
    [SerializeField] private GameObject _enableObject = null;

    void Start()
    {
        _myButton.onClick.AddListener(MyAction);
    }

    void MyAction()
    {
        StartCoroutine(doFade(_canvasGroup, _disableObject, _enableObject));
    }
    IEnumerator doFade(CanvasGroup canvasGroup, GameObject disableObject, GameObject enableObject)
    {
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime * 2;
            yield return null;

        }
        disableObject.SetActive(false);
        enableObject.SetActive(true);
        while (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime * 2;
            yield return null;

        }
        yield return null;
    }
}
