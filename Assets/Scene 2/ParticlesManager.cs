using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.VFX;

public class ParticlesManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ParticlesCountText;
    [SerializeField] private VisualEffect VisualEffect;

    private readonly CultureInfo culture = new("ru-RU");

    private void Update()
    {
        ParticlesCountText.text = $"Кол-во частиц: {VisualEffect.aliveParticleCount.ToString("#,#", culture)}";
    }
}
