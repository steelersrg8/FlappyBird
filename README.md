# Flappy Bird Clone in Unity 🐤🎮


## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [How to Play](#how-to-play)
- [Controls](#controls)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## Overview
This project is a **clone of the popular Flappy Bird game** developed using **Unity** and **C#**. It replicates the addictive gameplay where players control a bird that must navigate through a series of pipes without colliding with them. The game includes scoring, collision detection, and a restart option.

## Features
- Simple and intuitive controls
- Increasing difficulty as the game progresses
- Score tracking system
- Game over and restart functionality
- Sound effects for jumping and collisions

## Installation
Follow these steps to run the game locally:

1. **Clone the repository**:
    ```bash
    git clone https://github.com/steelersrg8/FlappyBird.git
    cd FlappyBird
    ```
2. **Open the project in Unity**:
   - Ensure you have **Unity Hub** installed.
   - Open Unity and select the version compatible with the project (recommended Unity version: `2021.x` or higher).
   - Open the project folder from Unity Hub.

3. **Play the game**:
   - Once the project loads in Unity, click the **Play** button to start the game.

## How to Play
- The objective of the game is to keep the bird in the air and navigate through the gaps between the pipes.
- The game ends if the bird hits a pipe or falls to the ground.
- Try to achieve the highest score possible!

## Controls
- **Spacebar** (or mouse click): Make the bird flap its wings and fly upward.

## Project Structure
```
FlappyBird/
├── Assets/
│   ├── Scripts/
│   │   ├── Bird.cs
│   │   ├── PipeSpawner.cs
│   │   ├── ScoreManager.cs
│   │   └── GameManager.cs
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Sprites/
│   ├── Audio/
│   └── Materials/
├── README.md
└── .gitignore
```

### Key Scripts:
- **Bird.cs**: Handles bird movement and collisions.
- **PipeSpawner.cs**: Manages spawning of pipes at regular intervals.
- **ScoreManager.cs**: Keeps track of the player's score.
- **GameManager.cs**: Manages game states like starting, pausing, and restarting.

Feel free to reach out if you have any questions or run into issues!
