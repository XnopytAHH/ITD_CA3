using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField]
    GameObject[] tutorialWalkPanels;
    [SerializeField]
    GameObject[] tutorialTeleportPanels;
    int currentWalkPanelIndex = 0;
    int currentTeleportPanelIndex = 0;
    public static Tutorial Instance;
    [SerializeField]
    GameObject EndTutorialUI;
    void Start()
    {
        Instance = this;
        tutorialWalkPanels[0].GetComponent<TutorialWalkPanel>().EnablePanel();
    }
    public void NextWalkPanel()
    {
        if (currentWalkPanelIndex < tutorialWalkPanels.Length - 1)
        {
            tutorialWalkPanels[currentWalkPanelIndex].GetComponent<TutorialWalkPanel>().DisablePanel();
            currentWalkPanelIndex++;
            tutorialWalkPanels[currentWalkPanelIndex].GetComponent<TutorialWalkPanel>().EnablePanel();
        }
        else
        {
            tutorialWalkPanels[currentWalkPanelIndex].GetComponent<TutorialWalkPanel>().DisablePanel();
            tutorialTeleportPanels[0].GetComponent<TutorialTeleportPanel>().EnablePanel();
        }
    }
    public void NextTeleportPanel()
    {
        if (currentTeleportPanelIndex < tutorialTeleportPanels.Length - 1)
        {
            tutorialTeleportPanels[currentTeleportPanelIndex].GetComponent<TutorialTeleportPanel>().DisablePanel();
            currentTeleportPanelIndex++;
            tutorialTeleportPanels[currentTeleportPanelIndex].GetComponent<TutorialTeleportPanel>().EnablePanel();
        }
        else
        {
            tutorialTeleportPanels[currentTeleportPanelIndex].GetComponent<TutorialTeleportPanel>().DisablePanel();
            EndTutorialUI.SetActive(true);
        }
    }
}
