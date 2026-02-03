using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    
    public AudioSource musicSource;
    public Button muteButton;
    public Image muteButtonImage;
    public Slider volumeSlider;
    
    public Sprite soundOnSprite;  // 🔊 sprite
    public Sprite soundOffSprite; // 🔈 sprite
    
    bool isMuted = false;
    
    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        // Set initial volume
        if(musicSource != null)
        {
            volumeSlider.value = musicSource.volume;
        }
        
        // Add button listener
        muteButton.onClick.AddListener(ToggleMute);
        
        // Add slider listener
        volumeSlider.onValueChanged.AddListener(ChangeVolume);
        
        UpdateMuteIcon();
    }
    
    public void ToggleMute()
    {
        isMuted = !isMuted;
        musicSource.mute = isMuted;
        UpdateMuteIcon();
    }
    
    public void ChangeVolume(float volume)
    {
        musicSource.volume = volume;
        
        // If volume is 0, show mute icon
        if(volume == 0)
        {
            muteButtonImage.sprite = soundOffSprite;
        }
        else
        {
            muteButtonImage.sprite = soundOnSprite;
        }
    }
    
    void UpdateMuteIcon()
    {
        if(isMuted || musicSource.volume == 0)
        {
            muteButtonImage.sprite = soundOffSprite;
        }
        else
        {
            muteButtonImage.sprite = soundOnSprite;
        }
    }
}