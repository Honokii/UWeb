// StreamingAssets/UWebManager.js
window.addEventListener('load', () => {
  function setupButton(buttonId, unityMessage) {
    const button = document.querySelector(buttonId);
    if (button) {
      button.onclick = () => {
        window.unityInstance.SendMessage('UWebManager', unityMessage);
      };
    } else {
      console.error(`${buttonId} not found in the DOM.`);
    }
  }

  function waitForUnityInstance() {
    if (window.unityInstance) {
      setupButton("#redButton", "RedButtonClick");
      setupButton("#yellowButton", "YellowButtonClick");
      setupButton("#greenButton", "GreenButtonClick");
    } else {
      setTimeout(waitForUnityInstance, 100); // Retry after 100ms
    }
  }

  waitForUnityInstance();
});