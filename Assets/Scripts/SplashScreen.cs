using DG.Tweening;

using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{
    public Image progressBar; // Assign your UI Image here
    public CanvasGroup splashScreenCanvasGroup; // Assign your splash screen CanvasGroup here
    public float fadeDuration = 1.0f;

    void Start()
    {
        // Ensure the fillAmount starts at 0
        progressBar.fillAmount = 0f;

        // Create a sequence for the loading progress
        Sequence loadingSequence = DOTween.Sequence();

        // Add realistic loading steps to the sequence
        loadingSequence.Append(progressBar.DOFillAmount(0.2f, 0.5f).SetEase(Ease.Linear)) // Start quickly to 20%
                        .Append(progressBar.DOFillAmount(0.4f, 1.0f).SetEase(Ease.OutQuad)) // Slow down to 40%
                        .Append(progressBar.DOFillAmount(0.5f, 0.5f).SetEase(Ease.Linear)) // Pause briefly at 50%
                        .Append(progressBar.DOFillAmount(0.7f, 0.8f).SetEase(Ease.InOutQuad)) // Speed up and slow down to 70%
                        .Append(progressBar.DOFillAmount(0.85f, 0.6f).SetEase(Ease.Linear)) // Smoothly move to 85%
                        .Append(progressBar.DOFillAmount(0.9f, 0.5f).SetEase(Ease.OutBounce)) // Slow down with a bounce to 90%
                        .Append(progressBar.DOFillAmount(1.0f, 1.0f).SetEase(Ease.InQuad)) // Finish loading to 100%
                        .OnComplete(OnLoadingComplete); // Call OnLoadingComplete when done
    }

    void OnLoadingComplete()
    {
        // This function is called when the loading is complete
        Debug.Log("Loading Complete!");

        splashScreenCanvasGroup.DOFade(0f, fadeDuration).OnComplete(() =>
        {
            // Optionally, deactivate the splash screen after fading out
            splashScreenCanvasGroup.gameObject.SetActive(false);
        });
    }
}
