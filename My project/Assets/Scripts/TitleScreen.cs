using UnityEngine;
using UnityEngine.SceneManagement;

// 타이틀 화면에서 게임 시작 처리
public class TitleScreen : MonoBehaviour
{
    [Tooltip("게임 플레이 씬 이름")]
    [SerializeField] private string gameplaySceneName = "Gameplay";

    [Header("사운드")]
    [Tooltip("타이틀 화면 BGM")]
    [SerializeField] private AudioClip titleBGM;
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        AudioManager.Instance?.PlayBGM(titleBGM);
    }
    // 버튼에서 호출: 게임 시작
    public void StartGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(gameplaySceneName);        
    }

    // 버튼에서 호출: 게임 종료
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}