using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Background")
        {
            Debug.Log("Destroyer touched background");
            return;
        }

        if (other.tag == "Player")
        {
            Debug.Break();
            return;
        }

        if (other.gameObject.transform.parent) 
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }

        else
        {
            Destroy(other.gameObject);
        }
    }
}
