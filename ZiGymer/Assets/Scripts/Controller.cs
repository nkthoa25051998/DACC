using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject pnlContent;
    public Text txtTitle;
    public Text txtContent;
    public Image illustration;

    // Start is called before the first frame update
    void Start()
    { 
        pnlContent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowContent(string title, string content, Vector3 position, Sprite source)
    {
        txtTitle.text = title;
        txtContent.text = content;
        float w = pnlContent.GetComponent<RectTransform>().rect.width;
        pnlContent.transform.position = new Vector3(position.x+w/2, pnlContent.transform.position.y, position.z);
        illustration.sprite = source;
        pnlContent.SetActive(true);
    }

    public void HideContent()
    {
        pnlContent.SetActive(false);
    }
}
