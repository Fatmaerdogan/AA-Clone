using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public List<GameObject> Panels;
    private void Start()
    {
        GameManager.instance.GameEndActive += GameEnd;
    }
    public void GameEnd(bool temp)
    {
        StartCoroutine(PanelSet(temp));
    }
    public IEnumerator PanelSet(bool temp)
    {
        yield return new WaitForSeconds(1f);
        Panels[0].SetActive(temp);
        Panels[1].SetActive(!temp);

    }
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
