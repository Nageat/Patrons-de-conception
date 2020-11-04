using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField]
    public static Manager instance = null;//Class manager
    [SerializeField]
    public int HP = 3;//PV -> HealthScript
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;//Si instance est null assigne a ce gameobject
        }
        else if (instance != this)
        {
            Destroy(gameObject);//Sinon la détruire
        }

    }
}
