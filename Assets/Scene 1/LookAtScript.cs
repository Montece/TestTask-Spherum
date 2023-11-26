using UnityEngine;

public class LookAtScript : MonoBehaviour
{
    [SerializeField] private Transform Target;

    private void Update()
    {
        transform.LookAt(Target);
    }
}
