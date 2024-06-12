using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        if (GameManager.instance.isGamever)
        {
            transform.Translate(Vector3.left * speed * Time.deltatime)
        }
    }
}
