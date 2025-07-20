using Unity.VisualScripting;
using UnityEngine;

public class Destroi : MonoBehaviour
{
    void Start()
    {
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Saiu do contato com: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Nuvem")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
