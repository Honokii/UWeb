using System;
using UnityEngine;
using UnityEngine.Events;

public class UWebManager : MonoBehaviour {
    public static UWebManager Instance;
    
    public UnityEvent onRedButtonClick = new UnityEvent();
    public UnityEvent onYellowButtonClick = new UnityEvent();
    public UnityEvent onGreenButtonClick = new UnityEvent();

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void RedButtonClick() {
        onRedButtonClick.Invoke();
    }
    
    public void YellowButtonClick() {
        onYellowButtonClick.Invoke();
    }
    
    public void GreenButtonClick() {
        onGreenButtonClick.Invoke();
    }
}
