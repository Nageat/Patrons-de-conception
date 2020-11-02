using UnityEngine;


public class TimeoutObject : MonoBehaviour
{
    [SerializeField]
    private float timeout = 2;

    private float startTime;

    private void OnEnable()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        if (Time.time - startTime > timeout)
        {
            Destroy(gameObject);//Destruction de l'objet apres le timeout
        }
    }
}