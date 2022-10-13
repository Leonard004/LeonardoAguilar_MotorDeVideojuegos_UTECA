using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int edad = 23;
    public float velocidad = 4.5f;
    public bool hasPower = false;
    private string Name = "Leo";
    int multiFace = 2;
    int conter = 0;
    bool CounterisGreterThamFive;
    int level = 1;

    float VelocityDisparo;
    int Daño;

    Rigidbody2D RB;
    Transform tranform;
    Sprite img;
    string name;
    BoxCollider2D collider;


    // Start is called before the first frame update
    void Start()
    {
        name = Name;

        float result = velocidad * multiFace;
    }

    // Update is called once per frame
    void Update()
    {
        if(level == 1)
        {
            //Basic Power
        }

        if (level == 1)
        {
            //Mid Power
        }

        if (level == 1)
        {
            //Advanc Power
        }

        if (conter >= 5 && CounterisGreterThamFive == false)
        {
            CounterisGreterThamFive = true;
        }

        if (conter >= 5 && CounterisGreterThamFive == false)
        {
            activarComboAnimation();
        }
    }

    public void activarComboAnimation ()
    {

    }
}
