using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
            transform.Translate(Vector3.left * speed * Time.deltatime)
    }
}
