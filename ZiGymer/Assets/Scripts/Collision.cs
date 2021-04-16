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
    public Collider2D backCollider;
    public Sprite backSource;
    public Collider2D waistCollider;
    public Sprite waistSource;
    public Collider2D leftHindThighsCollider;
    public Collider2D rightHindThighsCollider;
    public Sprite hindthighsSource;
    public Collider2D leftCalfCollider;
    public Collider2D rightCalfCollider;
    public Sprite calfSource;
    public Collider2D leftBicepsCollider;
    public Collider2D rightBicepsCollider;
    public Sprite BicepsSource;
    public Collider2D leftShoulderCollider;
    public Collider2D rightShoulderCollider;
    public Sprite ShoulderSource;

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
        if (collision == backCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ LƯNG";
            string content = System.IO.File.ReadAllText(@"Assets/Content/back.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, backSource);
        }
        if (collision == waistCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ EO";
            string content = System.IO.File.ReadAllText(@"Assets/Content/waist.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, waistSource);
        }
        if (collision == leftHindThighsCollider || collision == rightHindThighsCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ ĐÙI SAU";
            string content = System.IO.File.ReadAllText(@"Assets/Content/hindthighs.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, hindthighsSource);
        }
        if (collision == leftCalfCollider || collision == rightCalfCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ BẮP CHÂN";
            string content = System.IO.File.ReadAllText(@"Assets/Content/calf.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, calfSource);
        }
        if (collision == leftBicepsCollider || collision == rightBicepsCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ BẮP TAY";
            string content = System.IO.File.ReadAllText(@"Assets/Content/calf.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, BicepsSource);
        }
        if (collision == leftShoulderCollider || collision == rightShoulderCollider)
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPosition.z = 0;
            string title = "CƠ BẮP TAY";
            string content = System.IO.File.ReadAllText(@"Assets/Content/calf.txt");
            gameController.GetComponent<Controller>().ShowContent(title, content, Input.mousePosition, ShoulderSource);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameController.GetComponent<Controller>().HideContent();
    }
}
