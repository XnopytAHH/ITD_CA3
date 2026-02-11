using UnityEngine;

public class TutorialWalkPanel : MonoBehaviour
{
    BoxCollider panelCollider;
    GameObject panelVisual;
    void Awake()
    {
        panelVisual = transform.GetChild(0).gameObject;
        panelCollider = GetComponent<BoxCollider>();
        panelVisual.SetActive(false);
        panelCollider.enabled = false;
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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Tutorial.Instance.NextWalkPanel();
        }
    }
    
}
