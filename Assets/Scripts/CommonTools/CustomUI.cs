#if UnityEditor
using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;
public class CustomUI : MonoBehaviour
{
    [MenuItem("GameObject/CustomUI/Image")]
    static void CreatImage()
    {
        if (Selection.activeTransform)
        {
            if (Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                GameObject go = new GameObject("Image", typeof(Image));
                Image i = go.GetComponent<Image>();
                RectTransform rt = i.GetComponent<RectTransform>();
                i.raycastTarget = false;
                i.transform.SetParent(Selection.activeTransform);
            }
            else
            {
                GameObject go = new GameObject("Image", typeof(Image));
                Image i = go.GetComponent<Image>();
                RectTransform rt = i.GetComponent<RectTransform>();
                rt.position = Selection.activeTransform.position;
                i.raycastTarget = false;
                i.transform.SetParent(CustomUIManager.Instance.ActiveCanvas.transform);
            }
        }
    }
    [MenuItem("GameObject/CustomUI/Text")]
    static void CreatText()
    {
        if (Selection.activeTransform)
        {
            if (Selection.activeTransform.GetComponentInParent<Canvas>())
            {
                GameObject go = new GameObject("Text", typeof(Text));
                Text t = go.GetComponent<Text>();
                go.GetComponent<Text>().raycastTarget = false;
                go.transform.SetParent(Selection.activeTransform);
            }
            else
            {
                GameObject go = new GameObject("Image", typeof(Image));
                Text t = go.GetComponent<Text>();
                RectTransform rt = t.GetComponent<RectTransform>();
                rt.position = Selection.activeTransform.position;
                t.raycastTarget = false;
                t.transform.SetParent(CustomUIManager.Instance.ActiveCanvas.transform);
            }
        }
    }
}
#endif