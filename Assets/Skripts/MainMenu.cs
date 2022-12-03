using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Vector2 menuSize = new Vector2(500, 300);
    // ����������� ������ ������
    public float buttonMinHeight = 60f;
    // ����� ���������
    public Font captionFont;
    // ����� ������
    public Font buttonFont;
    // ������ ����
    public string mainMenuText = "Menu";
    public string startButtonText = "Start/Next Game ";
    public string exitButtonText = "Exit Game"; 
    public void OnGUI()
    { 
        // ������������ ������������� �� ������ ������ � �������� ��������
        Rect rect = new Rect(
        Screen.width / 2f - menuSize.x / 2, 
        Screen.height / 2f - menuSize.y / 2, 
        menuSize.x, 
        menuSize.y);
        // ������� ����
        GUILayout.BeginArea(rect, GUI.skin.textArea); 
        { 
            // ������� ����� ��������� �� ������ ����� label ������������ �����
            GUIStyle captionStyle = new GUIStyle(GUI.skin.label);
            // ������������� ����� ��������� ����� captionFont
            captionStyle.font = captionFont; 
            // ������������ ������ �� ������
            captionStyle.alignment = TextAnchor.MiddleCenter; 
            // ����� ���������
            GUILayout.Label(mainMenuText, captionStyle); 
            // ������� ����� ������ �� ������ ����� button ������������ �����
            GUIStyle buttonStyle = new GUIStyle(GUI.skin.button); 
            // ������������� ����� ������ ����� buttonFont
            buttonStyle.font = buttonFont; 
            // ������� ������ �� �����
            buttonStyle.margin = new RectOffset(20, 20, 3, 3);

        // FlexibleSpace - ������������� ������������ �����, ����������� ��� 
        // ���������� ������� ������������ ����� ���������� ����������
        GUILayout.FlexibleSpace(); 
         // ������������ ������������ ����� ���������� � ������� ����� 
         // ��������� ������ Start � ��������� �� �������
         if (GUILayout.Button(startButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight))) 
            { 
                // �������� ����� � ������ Level
                SceneManager.LoadScene("Level"); 
            }
            GUILayout.FlexibleSpace(); 
            // ������������ ������������ ����� �������� 
            // ��������� ������ Exit � ��������� �� �������
            if (GUILayout.Button(exitButtonText, buttonStyle, GUILayout.MinHeight(buttonMinHeight))) 
            { 
                // �����
                // Application.Quit();
                } 
            GUILayout.FlexibleSpace();
            // ������������ ������������ ����� ������� Exit � ����� ������� ����
            } 
        GUILayout.EndArea(); 
    }
}
       