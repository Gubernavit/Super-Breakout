using UnityEngine;

public class Derrota : MonoBehaviour
{
    Vector3 pos = new Vector3(0f, 0f, 0f);
    [SerializeField] private float GameoverLimite = -4.5f;
    [SerializeField] GameObject gameover;
    [SerializeField] GameObject bola;
    void Start()
    {
        
    }
        void Update()
    {

        if (transform.position.y - 0.2f <= -4.5f)
        {
            gameover.SetActive(true);
            bola.SetActive(false);
            transform.position = pos;
        }
    }
}