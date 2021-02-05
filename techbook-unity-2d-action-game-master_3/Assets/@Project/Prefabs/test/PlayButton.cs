using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour, IPointerEnterHandler
{
    private Button pb;
    public Sprite Sprite;

    private void Start()
    {
        print("1");
        pb = GetComponent<Button>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("1");
        throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("2");
        throw new System.NotImplementedException();
    }
}
