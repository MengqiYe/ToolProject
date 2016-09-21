using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;
using UnityEngine.UI;

public class CustomUIManager : Singleton<CustomUIManager>
{
    public Canvas ActiveCanvas;
    public GameObject Target;
    public GameObject Prefab;
    void Start()
    {
        //GuideToGameObject(Target);
    }

    public GameObject GuideToGameObject(GameObject go)
    {
        GameObject uiGo = Instantiate(Prefab);
        float offsetUp = 0;
        uiGo.transform.position = go.transform.position;
        uiGo.transform.parent = ActiveCanvas.transform;
        float scale = uiGo.transform.position.z / 6;
        uiGo.transform.localScale = new Vector3(scale, scale, scale);
        BoxCollider c = go.GetComponent<BoxCollider>();
        if (c != null)
        {
            offsetUp += c.size.y / 2f + uiGo.transform.localScale.y / 2f;
        }
        uiGo.transform.position += offsetUp * Vector3.up;
        return uiGo;
    }
}
