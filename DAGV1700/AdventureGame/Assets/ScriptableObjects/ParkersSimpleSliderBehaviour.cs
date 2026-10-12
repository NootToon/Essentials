using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Slider))]
public class ParkersSimpleSliderBehaviour : MonoBehaviour
{
    public ScriptableObject dataObj;

    private Slider sliderObj;

    private void Awake()
    {
        sliderObj = GetComponent<Slider>();
        UpdateWithFloatData();
    }

    public void UpdateWithFloatData()
    {
        float newValue;

        if (dataObj is SimpleFloatData simpleData)
        {
            newValue = simpleData.value;
        }
        else if (dataObj is FloatData floatData)
        {
            newValue = floatData.Value;
        }
        else
        {
            Debug.LogWarning(
                "Data Obj must be either SimpleFloatData or FloatData.",
                this
            );
            return;
        }

        sliderObj.value = newValue;

        if (newValue <= 0f)
        {
            Debug.LogWarning("YOU DIED");
            //SceneManager.LoadScene(
            //    SceneManager.GetActiveScene().buildIndex
            //);
        }
    }
}