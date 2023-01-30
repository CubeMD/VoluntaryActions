using JetBrains.Annotations;
using UnityEngine;

public class Symbol : MonoBehaviour
{
    [SerializeField] private GameObject xGameObject;
    [SerializeField] private GameObject oGameObject;
    // [SerializeField] private Renderer ren;
        
        
    [SerializeField] private bool isSymbolX;
    public bool IsSymbolX => isSymbolX;


    // [CanBeNull] private Coroutine SensedRoutine;

    public void SetSymbol(bool isX)
    {
        isSymbolX = isX;
        xGameObject.SetActive(isSymbolX);
        oGameObject.SetActive(!isSymbolX);
    }

    // public void SetSensedMaterialRoutine()
    // {
    //     if (SensedRoutine != null)
    //     {
    //         SensedRoutine = StartCoroutine()
    //     }
    // }
}