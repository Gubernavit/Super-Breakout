using UnityEngine;

public class Vitoria : MonoBehaviour
{
    [SerializeField] GameObject Bola;
    [SerializeField] GameObject vitoria;
    void Start()
    {
        
    }
    void Update()
    {
        if (GameObject.FindWithTag("Nuvem") == null)
        {
            Debug.Log("Todos as Nuvens destruidas!!");
            Bola.SetActive(false);
            vitoria.SetActive(true);
        }
    }
}
