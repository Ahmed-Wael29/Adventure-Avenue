using UnityEngine;

public class HideAndShowObject : MonoBehaviour
{
    public GameObject objectToShowHide;
    public float delayTime = 10f;
    public float hideTime = 3f;
    private bool hasShown = false;

    void Start()
    {
        objectToShowHide.SetActive(false);
        Invoke("ShowObject", delayTime);
    }

    void ShowObject()
    {
        objectToShowHide.SetActive(true);
        if (!hasShown)
        {
            Invoke("HideObject", hideTime);
            hasShown = true;
        }
    }

    void HideObject()
    {
        objectToShowHide.SetActive(false);
    }
}