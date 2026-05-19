<h1 align="center">Running Penguin</h1>

<p align="center">
A 2D endless runner game developed with Unity and C#.<br>
Control a running penguin, avoid incoming obstacles, and survive as long as possible to beat the high score.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022.3.7f1-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/UI-Unity%20UI-0E7FBF"/>
  <img src="https://img.shields.io/badge/Physics-Unity%202D-orange"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Mode-2D%20Single%20Player-red"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

## Project Overview

**Running Penguin** is a simple and fast 2D endless runner game where the player controls a penguin moving through an icy side-scrolling environment.

The goal is straightforward:

- keep the penguin alive,
- jump over low obstacles,
- slide under higher obstacles,
- avoid collisions,
- collect as many survival points as possible,
- beat the saved high score.

The game uses a compact arcade-style loop: start from the menu, play instantly, lose on collision, then retry for a better score.

<img width="1940" height="1100" alt="running penguin gameplay" src="https://github.com/user-attachments/assets/580900b5-3020-4f14-8ce2-aee7bbc2766f" />

<img width="1940" height="1100" alt="running penguin slide" src="https://github.com/user-attachments/assets/fd264ade-9455-4899-b0e3-9f96bc4b9c82" />

---

## Supported Platform

Running Penguin is currently organized as a **PC Unity project**.

- Keyboard input is used for gameplay.
- The project can be opened directly from the repository root in Unity Hub.
- Compiled builds are not stored in the source repository.

---

## Project Structure

```text
Running_Penguin/
|-- Assets/
|   |-- Scenes/
|   |   |-- menu.unity
|   |   `-- game.unity
|   |-- scripts/
|   |   |-- mainscript.cs
|   |   |-- animationcode.cs
|   |   `-- cloudscript.cs
|   |-- sounds/
|   |-- JellyIcons/
|   |-- Nine Pines Animation/
|   |-- Tavern Music Free Pack/
|   `-- TextMesh Pro/
|-- Packages/
|   |-- manifest.json
|   `-- packages-lock.json
|-- ProjectSettings/
|-- LICENSE
|-- README.md
`-- .gitignore
```

Unity-generated folders such as `Library`, `Logs`, `UserSettings`, and `obj` are intentionally ignored by Git.

---

## Core Systems

### Player Control

- Jump input with `Space` or `Up Arrow`.
- Slide input with `Down Arrow`.
- Ground check prevents repeated mid-air jumping.
- Restart and menu navigation are available through keyboard shortcuts and UI buttons.

### Obstacle System

- A moving obstacle travels from right to left across the screen.
- When the obstacle leaves the play area, it respawns from the right side.
- The obstacle respawn height is randomized to vary jump and slide timing.
- Obstacle speed increases over time to raise difficulty.

### Score and High Score

- Score increases continuously while the player survives.
- The high score is saved locally with Unity `PlayerPrefs`.
- The current score and high score are displayed with TextMeshPro UI.

### Game Over Flow

- A collision or invalid player position ends the run.
- The game pauses with `Time.timeScale = 0`.
- A game over canvas is shown.
- The player can retry immediately or return to the menu.

### Environment Motion

- Background clouds move from right to left.
- Clouds are repositioned with randomized vertical placement after leaving the screen.
- The scrolling background supports the feeling of continuous forward movement.

---

## Features

### Endless Runner Gameplay

- Fast restart-focused arcade loop.
- Increasing obstacle speed as the score grows.
- Simple controls built around timing and reaction.

### Animated Penguin Character

- Running, jumping, and sliding animation states.
- Animation triggers respond to gameplay input.
- Penguin visual assets are included inside the Unity project.

### Menu and UI Flow

- Main menu scene with play and exit actions.
- Game scene with score, high score, and game over UI.
- Keyboard shortcuts for retrying and returning to the menu.

### Audio Feedback

- Jump sound effect.
- Defeat sound effect.
- Background music assets included in the project.

---

## Game Mechanics

### Jumping

The penguin can jump when it is close to the ground. Jumping applies upward velocity to the player Rigidbody2D and plays the jump sound.

### Sliding

Sliding is triggered with the down arrow. It changes the penguin animation and temporarily adjusts obstacle interaction timing by disabling the obstacle collider when the slide condition is valid.

### Difficulty Scaling

The obstacle starts with a steady leftward movement. As the score reaches certain intervals, the obstacle velocity increases, making later runs faster and more demanding.

### Scoring

The score increases during gameplay while the player remains alive. When the current score passes the saved high score, the high score value is updated locally.

---

## How to Play

1. Start the game from the main menu.
2. Watch the obstacle coming from the right side of the screen.
3. Jump over low obstacles.
4. Slide under higher obstacles.
5. Survive as long as possible.
6. Retry after game over to beat the high score.

---

## Controls

| Action | Control |
|---|---|
| Jump | `Space` or `Up Arrow` |
| Slide | `Down Arrow` |
| Retry | `Enter` |
| Return to Menu | `Escape` |
| Menu Buttons | Mouse click |

---

## Technologies Used

- **Unity Engine 2022.3.7f1** - game development engine.
- **C#** - gameplay, UI, scene, and score logic.
- **TextMeshPro** - score and high score text rendering.
- **Unity UI (UGUI)** - menus, buttons, and game over interface.
- **Unity 2D Physics** - Rigidbody2D movement and collision-based gameplay.
- **Unity Animator** - penguin running, jumping, and sliding animations.

---

## Assets and Audio

### Visual Assets

- 2D Penguin Character Animation Pack:

https://assetstore.unity.com/packages/2d/characters/2d-character-sprite-animation-penguin-236747

- Jelly Icons:

https://assetstore.unity.com/packages/2d/gui/icons/jelly-icons-99749

### Audio Assets

- RPG Essentials Sound Effects - FREE:

https://assetstore.unity.com/packages/audio/sound-fx/rpg-essentials-sound-effects-free-227708

- Fantasy Tavern Music Free Pack:

https://assetstore.unity.com/packages/audio/music/fantasy-tavern-music-free-pack-118847

---

## Installation and Play

1. Clone the repository:

```bash
git clone https://github.com/AFurkanOcel/Running_Penguin.git
```

2. Open the project folder with Unity Hub:

```text
Running_Penguin
```

3. Use **Unity 2022.3.7f1** or a compatible Unity 2022.3 LTS version.

4. Open the main menu scene:

```text
Assets/Scenes/menu.unity
```

5. Press **Play** in the Unity Editor.

### Builds

Compiled builds are not stored in this source repository. Release builds should be distributed through GitHub Releases, itch.io, or another download page.

---

## Credits

### Game Development

**A. Furkan ÖCEL**

GitHub: https://github.com/AFurkanOcel

---

## License

This project is licensed under the terms included in the repository's `LICENSE` file.
