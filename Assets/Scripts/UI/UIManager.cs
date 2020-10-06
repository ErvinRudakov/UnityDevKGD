using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private Fader _fader;
        public static UIManager Instance;
        void Start()
        {
            _fader.OnFadeIn += LoadGameplayScene;
            _fader.FadeIn();
        }
        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        private void OnSceneFadeIn()
        {
            StartCoroutine(FadeOutAndLoadGameplay());
        }
        private IEnumerator FadeOutAndLoadGameplay()
        {
            yield return new WaitForSeconds(3f);
            _fader.OnFadeOut += LoadGameplayScene;
            _fader.FadeOut();
        }
        private void LoadGameplayScene()
        {
            StartCoroutine(LoadGameplaySceneCoroutine());
        }
        private IEnumerator LoadGameplaySceneCoroutine()
        {
            SceneManager.LoadScene("Gameplay");
            yield return new WaitForSeconds(5f);
            _fader.FadeOut();
        }
    }
}
