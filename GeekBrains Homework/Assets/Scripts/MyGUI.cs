
using UnityEngine;

public class MyGUI : MonoBehaviour
{
    public string livesAmount;
    public Texture2D _icon;
    private float sliderValue;

    void OnGUI()
    {
        //количество жизней игрока (пример)
        GUI.Box(new Rect(10, 10, 100, 50), new GUIContent(livesAmount, _icon));


        GUILayout.BeginArea(new Rect(700, 400, 200, 100));
        GUILayout.BeginHorizontal();
        GUILayout.BeginVertical();
        if (GUILayout.RepeatButton("Min"))
            sliderValue = 69.0f;
        if (GUILayout.RepeatButton("Max"))
            sliderValue = 9000.0f;
        GUILayout.EndVertical();
        GUILayout.BeginVertical();
        GUILayout.Label("Слайдер бесполезности: ");
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 69.0f, 9000.0f);
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }

}
