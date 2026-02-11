using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

public class TutorialTeleportPanel : MonoBehaviour
{
    TeleportationArea panelCollider;
    GameObject panelVisual;
    void Awake()
    {
        panelVisual = transform.GetChild(0).gameObject;
        panelCollider = GetComponent<TeleportationArea>();
        panelVisual.SetActive(false);
        panelCollider.enabled = false;
    }
    public void TeleportedToPanel()
    {
        Tutorial.Instance.NextTeleportPanel();
    }
    public void EnablePanel()
    {
        panelCollider.enabled = true;
        panelVisual.SetActive(true);
    }

    public void DisablePanel()
    {
        panelCollider.enabled = false;
        panelVisual.SetActive(false);
    }
    
}
