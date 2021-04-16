using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject gameController;
    public Collider2D chestCollider;
    public Sprite chestSource;
    public Collider2D stomachCollider;
    public Sprite stomachSource;
    public Collider2D leftThighsCollider;
    public Collider2D rightThighsCollider;
    public Sprite thighsSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == chestCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ NGỰC";
            string content = System.IO.File.ReadAllText(@"Assets/Content/chest.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, chestSource);
        }
        if (collision == stomachCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ BỤNG";
            string content = System.IO.File.ReadAllText(@"Assets/Content/stomach.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, stomachSource);
        }
        if (collision == leftThighsCollider || collision == rightThighsCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ ĐÙI";
            string content = System.IO.File.ReadAllText(@"Assets/Content/thighs.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, thighsSource);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameController.GetComponent<Controller>().HideContent();
    }
}
