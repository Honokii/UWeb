using System;
using UnityEngine;
using UnityEngine.UI;

namespace UWeb.Sample {
    public class SampleGameManager : MonoBehaviour {
        [SerializeField] private Image circle;

        private void Start() {
            UWebManager.Instance.onRedButtonClick.AddListener(TintRed);
            UWebManager.Instance.onYellowButtonClick.AddListener(TintYellow);
            UWebManager.Instance.onGreenButtonClick.AddListener(TintGreen);
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.Q)) TintRed();
            if (Input.GetKeyDown(KeyCode.W)) TintYellow();
            if (Input.GetKeyDown(KeyCode.E)) TintGreen();
        }

        private void TintRed() {
            circle.color = Color.red;
        }
        
        private void TintYellow() {
            circle.color = Color.yellow;

        }
        
        private void TintGreen() {
            circle.color = Color.green;

        }
    }
}