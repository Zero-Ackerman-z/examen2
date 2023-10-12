using UnityEngine;

public class Transformaciones : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotacion;

    [SerializeField]
    private Vector3 traslacion;

    [SerializeField]
    private Vector3 escalado;

    void Update()
    {
        // Rotaci�n del objeto
        transform.Rotate(rotacion * Time.deltaTime);

        // Traslaci�n del objeto
        transform.Translate(traslacion * Time.deltaTime);

        // Escalado del objeto
        transform.localScale = escalado;
    }
}
