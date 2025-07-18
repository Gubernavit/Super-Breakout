using UnityEngine;

public class ColisorTestCorreto : MonoBehaviour
{
    [SerializeField] int i = 0;
    [SerializeField] GameObject quadradoVerde;
    [SerializeField] Transform quadradoAzul;

    Vector3 pos = new Vector3(0f, 0f);
    void Start()
    {

    }

    void Update()
    {
        float distancia = Vector3.Distance(quadradoVerde.transform.position, quadradoAzul.position);
        if (distancia < 1f)
        {
            Debug.Log("Colidiu");
        }
        else
        {
            Debug.Log("Nao Colidiu");
        }
    }
}