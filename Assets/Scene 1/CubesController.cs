using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubesController : MonoBehaviour
{
    [SerializeField] private int Speed;
    [SerializeField] private Transform RedCube;
    [SerializeField] private Transform GreenCube;
    [SerializeField] private TMP_Text CubesDistanceText;
    [SerializeField] private GameObject Spheres;
    [SerializeField] private string Scene2Name;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) RedCube.position += Speed * Time.deltaTime * Vector3.right;
        if (Input.GetKey(KeyCode.S)) RedCube.position += Speed * Time.deltaTime * Vector3.left;
        if (Input.GetKey(KeyCode.A)) RedCube.position += Speed * Time.deltaTime * Vector3.forward;
        if (Input.GetKey(KeyCode.D)) RedCube.position += Speed * Time.deltaTime * Vector3.back;

        if (Input.GetKey(KeyCode.UpArrow)) GreenCube.position += Speed * Time.deltaTime * Vector3.right;
        if (Input.GetKey(KeyCode.DownArrow)) GreenCube.position += Speed * Time.deltaTime * Vector3.left;
        if (Input.GetKey(KeyCode.RightArrow)) GreenCube.position += Speed * Time.deltaTime * Vector3.back;
        if (Input.GetKey(KeyCode.LeftArrow)) GreenCube.position += Speed * Time.deltaTime * Vector3.forward;

        float distance = Vector3.Distance(RedCube.position, GreenCube.position);
        CubesDistanceText.text = $"Расстояние: {distance}";
        Spheres.SetActive(distance < 2f);
        if (distance < 1f) SceneManager.LoadScene(Scene2Name);
    }
}
