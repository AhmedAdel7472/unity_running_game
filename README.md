# 🤖 Robot Runner - 2D Platformer Game

A 2D side-scrolling platformer game built in Unity featuring a robot character with multiple animation states, collectible coins, and full audio controls.

![Unity](https://img.shields.io/badge/Unity-2D-black)
![C#](https://img.shields.io/badge/C%23-Scripts-blue)
![Status](https://img.shields.io/badge/Status-Complete-success)

---

## 🎮 Features

### 🎭 Character System
- **2D Robot Character**: Custom sprite-based character replacing the original Flappy Bird
- **Three Animation States**: 
  - **Idle State**: Played when character is not moving
  - **Run State**: Played during normal gameplay
  - **Jump State**: Played when character jumps
- **Multi-Sprite Animations**: Each state uses multiple sprite frames for smooth animation
- **Physics-Based Movement**: Character uses Unity's physics system for jumping and gravity

### 🎯 Gameplay Mechanics
- **Infinite Runner**: Endless side-scrolling gameplay
- **Coin Collection System**: 
  - Rotating coins placed throughout the level
  - **Smart Coin Placement**: Coins are positioned to prevent overlap even when environment repeats
  - Collectible coins increase player score
- **Score System**: 
  - Real-time score display in UI
  - Score increases when collecting coins
  - **Score resets automatically** when game restarts
- **Repeating Environment**: Seamless looping background for infinite runner experience

### 🎨 Visual Design
- **Stable Background**: Background remains static when character is in idle state
- **Scrolling Background**: Background moves when character is running/jumping
- **Rotated Coins**: Coins rotate continuously for visual appeal
- **Polished UI**: Clean user interface with score display and audio controls

### 🔊 Audio System
- **Background Music**: Looping background music during gameplay
- **Mute Toggle Button**: 
  - Visual button in UI with icon that changes state
  - 🔈 icon when muted
  - 🔊 icon when unmuted
  - Toggles background music on/off
- **Volume Slider**: 
  - UI slider component for volume control
  - Adjusts background music volume in real-time
  - **Auto-mute behavior**: When volume slider reaches 0, sound icon automatically changes to muted (🔈)
  - Volume control affects all game audio

---

## 🚀 Getting Started

### Prerequisites
- **Unity Editor**: Unity 2020.3 LTS or newer recommended
- **Platform**: Windows, macOS, or Linux
- **Git**: For version control (optional)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/AhmedAdel7472/unity_running_game.git
   cd unity_running_game
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Add" or "Open"
   - Navigate to the cloned project folder
   - Select the folder and click "Open"
   - Wait for Unity to import all assets

3. **Play the Game**
   - Open the main game scene (usually in `Assets/Scenes/`)
   - Click the Play button in Unity Editor
   - Or build and run for your target platform

---

## 🎯 How to Play

### Controls
| Action | Control |
|--------|---------|
| Jump | `SPACE` or `Left Mouse Click` |
| Mute/Unmute | Click the 🔊/🔈 button in UI |
| Adjust Volume | Drag the volume slider |

### Objective
- Collect as many golden coins as possible
- Keep running and jumping through the environment
- Beat your high score!

---

## 🏗️ Project Structure

```
unity_running_game/
│
├── Assets/
│   ├── Scenes/
│   │   └── MainGame.unity          # Main game scene
│   │
│   ├── Scripts/
│   │   ├── PlayerController.cs     # Character movement and animation
│   │   ├── CoinManager.cs          # Coin spawning and collection
│   │   ├── GameManager.cs          # Game state and score management
│   │   ├── AudioManager.cs         # Background music and sound control
│   │   └── UIManager.cs            # UI updates and controls
│   │
│   ├── Sprites/
│   │   ├── Robot/
│   │   │   ├── Idle/               # Idle animation sprites
│   │   │   ├── Run/                # Run animation sprites
│   │   │   └── Jump/               # Jump animation sprites
│   │   ├── Coin/                   # Coin sprites
│   │   └── Background/             # Background elements
│   │
│   ├── Animations/
│   │   ├── Robot_Idle.anim
│   │   ├── Robot_Run.anim
│   │   ├── Robot_Jump.anim
│   │   └── RobotAnimator.controller
│   │
│   ├── Audio/
│   │   └── BackgroundMusic.mp3     # Background music file
│   │
│   ├── Prefabs/
│   │   ├── Robot.prefab
│   │   └── Coin.prefab
│   │
│   └── UI/
│       └── Canvas elements and UI sprites
│
├── ProjectSettings/
├── Packages/
└── README.md
```

---

## 🎨 Technical Implementation

### Character Animation System
- **Animator Controller**: State machine managing transitions between Idle, Run, and Jump states
- **Sprite Animations**: Each state uses multiple sprite frames for smooth animation
- **State Transitions**: Automatic transitions based on character velocity and input

### Background Scrolling
- **Conditional Scrolling**: Background only moves when character is actively playing
- **Idle Stability**: Background remains completely static during idle state
- **Seamless Looping**: Infinite scrolling effect using repeating background sprites

### Coin System
- **Strategic Placement**: Coins positioned with proper spacing to avoid overlap
- **Environment Repetition Safety**: Algorithm ensures coins don't stack when environment loops
- **Rotation Effect**: Coins continuously rotate around their Z-axis for visual appeal
- **Collision Detection**: Uses Unity's 2D trigger system for collection

### Audio Management
- **AudioSource Component**: Handles background music playback
- **UI Integration**: Mute button and volume slider connected to AudioSource
- **State Persistence**: Audio settings maintained during gameplay
- **Dynamic Icon Switching**: UI icon updates based on mute state and volume level

### Score System
- **Real-time Updates**: UI text updates immediately upon coin collection
- **Reset Functionality**: Score automatically resets to 0 on game restart
- **TextMeshPro**: Uses TMP for crisp, scalable UI text (or Unity UI Text component)

---

## 🛠️ Development

### Key Scripts Overview

#### PlayerController.cs
- Handles player input (jump)
- Manages character physics and movement
- Controls animation state transitions
- Detects ground collision

#### CoinManager.cs
- Spawns coins at calculated intervals
- Ensures proper spacing between coins
- Handles coin collection logic
- Updates score when coins are collected

#### AudioManager.cs
- Plays/stops background music
- Handles mute toggle functionality
- Manages volume slider input
- Updates UI icons based on audio state

#### GameManager.cs
- Controls game state (start, playing, game over)
- Resets score on game restart
- Manages UI screen transitions

---

## 🎮 Building the Game

### Build Settings
1. Go to `File > Build Settings`
2. Select your target platform (PC, Mac, Linux, WebGL, etc.)
3. Click `Build` or `Build and Run`

### Recommended Build Platforms
- **Windows Standalone**: `.exe` application
- **macOS Standalone**: `.app` application
- **WebGL**: Play in browser
- **Android/iOS**: Mobile platforms

---

## 📝 Features Checklist

- [x] 2D character replacing Flappy Bird (Robot)
- [x] Three character states: Idle, Run, Jump
- [x] Multiple sprites per animation state
- [x] Stable background during idle state
- [x] Rotated coins throughout environment
- [x] Smart coin placement preventing overlap
- [x] Score system with real-time updates
- [x] Score reset on game restart
- [x] Background music
- [x] UI mute button with icon toggle (🔈/🔊)
- [x] UI volume slider
- [x] Auto-mute when volume reaches zero

---

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

---

## 🙏 Acknowledgments

- Unity Technologies for the game engine
- Character sprite assets third-party completely free
- Background music third-party completely free
- Community tutorials and resources

---

## 📧 Contact

Ahmed Adel Rasmy - instagram- Ahmed_Adel7274

Project Link: [https://github.com/yourusername/robot-runner](https://github.com/AhmedAdel7472/unity_running_game)

---

## 🎯 Future Enhancements

- [ ] add Obsticales
- [ ] Power-ups system
- [ ] Multiple character skins
- [ ] Difficulty progression
- [ ] Leaderboard system
- [ ] Sound effects for jumps and coin collection
- [ ] Particle effects
- [ ] Multiple background themes
- [ ] Mobile touch controls

---

**Made with ❤️ and Unity**
