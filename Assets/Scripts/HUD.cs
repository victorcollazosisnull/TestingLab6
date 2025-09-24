using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] private Text hpText;

    public int CurrentHPShown { get; private set; }

    public void SetHP(int value)
    {
        CurrentHPShown = value;

        if (hpText != null)
        {
            hpText.text = $"HP: {value}";
        }
        else
        {
            Debug.LogWarning("hpText no asignado en el inspector");
        }
    }
}
