using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    [SerializeField]
    private TMP_Text feedbackText;
    [SerializeField]
    private TMP_InputField usernameInput;
    [SerializeField]
    private TMP_InputField passwordInput;
    [SerializeField]
    private string correctUsername = "admin";
    [SerializeField]
    private string correctPassword = "password123";
    public void OnLoginButtonClicked()
    {
        if(usernameInput.text == correctUsername && passwordInput.text == correctPassword)
        {
            feedbackText.text = "Login successful!";
            Debug.Log("User logged in successfully.");
            SceneManager.LoadScene("MyScene");
        }
        else
        {
            feedbackText.text = "Invalid username or password.";
            Debug.Log("Login failed: Invalid credentials.");
        }
    }
    public void OnLoginButtonRelease()
    {
        Debug.Log("Login button released!");
        // Add your login release logic here
    } 
}
