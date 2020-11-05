using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patronsdeconception.Assets.Scenes.AbstractFactory {
public class AbsFactory : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    [SerializeField]
    private string[] CarColors = new string[4] { "Rouge", "Verte", "Bleu", "Jaune" };

    void Start()
    {
        for (int i=0; i>4; i++)
            {
                Instantiate(prefabs[i], new Vector3(0, i, 0), Quaternion.identity);
            }

        }

    // Update is called once per frame
    void Update()
    {

    }
}
}