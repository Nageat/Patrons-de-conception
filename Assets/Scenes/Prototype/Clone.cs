using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public voiture Voiture;
    
    public virtual void Vitesse()
    {
        Debug.Log(Voiture.Couleur + "Roule a " + Voiture.speed);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
