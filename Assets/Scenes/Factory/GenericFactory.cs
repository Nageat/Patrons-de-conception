using UnityEngine;

//Creation de la Factory
public class GenericFactory<i> : MonoBehaviour where i : MonoBehaviour
{
    [SerializeField]
    private i prefab;

    public i GetNewInstance()
    {
        return Instantiate(prefab);//Creation des instances de classe 
    }
}