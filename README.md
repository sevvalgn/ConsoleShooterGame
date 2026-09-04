# ShooterGame

ShooterGame is an ongoing game development project that started as a console-based shooter and gradually evolved into a graphical Windows Forms application.

I created this project to challenge myself by continuing to develop the same project instead of starting a new project whenever I wanted to learn something new. The project has grown step by step as I learned new concepts, solved problems, and improved the structure of the application.

## Features

- Multiple playable characters with different health and attack values
- Shooting and enemy projectile systems
- Jumping
- Collision detection
- Sprite-based animations
- Damage and health systems
- Login and registration
- MySQL database integration
- Persistent leaderboard
- Feedback system
- Graphical user interface with Windows Forms
- Victory and Game Over states

## Screenshots

### Login

<img width="1430" height="958" alt="Ekran görüntüsü 2026-09-04 140821" src="https://github.com/user-attachments/assets/cdfb0f1b-2874-4008-b78c-569d7034174f" />

### Registeration

<img width="1452" height="976" alt="Ekran görüntüsü 2026-09-04 141939" src="https://github.com/user-attachments/assets/d1c819ce-9aa1-431f-a0b0-7cb25bbcc716" />


### Main Menu

<img width="1438" height="898" alt="Ekran görüntüsü 2026-09-04 140904" src="https://github.com/user-attachments/assets/89e6a4a0-1c9e-4882-abd0-2b0fdde5b2e4" />


### Character Selection

<img width="1446" height="942" alt="Ekran görüntüsü 2026-09-04 140918" src="https://github.com/user-attachments/assets/2b86e9ca-af58-4318-a047-7092eb76ee61" />



### Gameplay

<img width="1436" height="992" alt="Ekran görüntüsü 2026-09-04 141008" src="https://github.com/user-attachments/assets/a3573d0f-1d66-4e48-8377-2e893529fec4" />

<img width="1436" height="946" alt="Ekran görüntüsü 2026-09-04 142050" src="https://github.com/user-attachments/assets/2ee4c42b-3f8a-40e1-a6c0-c44a806ab623" />



### Game Over / Victory

<img width="1448" height="1000" alt="Ekran görüntüsü 2026-09-04 143316" src="https://github.com/user-attachments/assets/787985fc-22a5-4928-91f8-aad95671aedb" />



### Leaderboard

<img width="1456" height="938" alt="Ekran görüntüsü 2026-09-04 142809" src="https://github.com/user-attachments/assets/1e715fa6-a9ef-435e-b4ec-0028934e24e2" />



### Feedback

<img width="1468" height="1004" alt="Ekran görüntüsü 2026-09-04 142818" src="https://github.com/user-attachments/assets/3a9e15c2-ceb5-4b6e-a352-40cceb84e244" />


## Characters

| Character | Health | Attack |
|-----------|--------:|-------:|
| Fairy     | 800     | 250    |
| Soldier   | 500     | 500    |
| OldMan    | 300     | 1000   |
| Enemy     | 14000   | 100    |

The characters have different gameplay statistics and their own visual assets, animation frames, projectile graphics, and health-bar states.

## Roadmap

✅ Console shooter game

✅ Login system

✅ Database integration

✅ Persistent leaderboard

✅ Graphical user interface with Windows Forms

✅ Improved project structure and code organization

🔜 Build an online leaderboard system

🔜 Further improve project architecture and code organization

## Project Progress

### ✅ Step 1 — Core Game

The project originally started as a console-based shooter. At this stage, I focused on building the game itself and improving my existing C# and object-oriented programming knowledge for gameplay.

This included character selection, movement, shooting, jumping, projectiles, collision detection, scoring, and game-state handling.

### ✅ Step 2 — Database Integration

After building the core game, I introduced MySQL and learned SQL and database integration through the project.

This added user registration, login, persistent scores, and leaderboard functionality, allowing information to be stored between sessions.

### ✅ Step 3 — Graphical UI and Project Structure

The next major step was moving the project from the console into a graphical Windows Forms application.

This was more than replacing console output with images. I had to adapt the game loop, timing, input handling, and game state to an event-driven graphical environment while adding sprite animations, graphical health bars, character selection, menus, feedback, and other visual elements.

Altough this stage improved the structure of the project, there is still room to improve the architecture as the project becomes more complex, but this was an important step toward a better structured application.

### 🔜 Step 4 — Online Leaderboard

The final planned stage is to make the leaderboard online.

The current version stores leaderboard data using the database integration developed in the previous stage. The goal is to eventually provide a shared online leaderboard so that players can compete for high scores.

## What I Practiced

### OOP

- Inheritance
- Polymorphism
- Constructor chaining
- Class design
- Encapsulation

### Game Development

- Game loops
- Collision detection
- Projectile systems
- Animation
- State management
- Time-based mechanics
- Real-time input

### UI and Database

- Windows Forms
- Event-driven programming
- SQL fundamentals
- MySQL integration
- Connecting database logic with application logic
- Organizing a larger multi-form project

## Technologies

- C#
- .NET
- Windows Forms
- MySQL
- MySqlConnector

## Database

MySQL is currently used for:

- User accounts
- Login and registration
- Persistent scores
- Leaderboard data
- Player feedback

Database credentials are not included in the repository.

The database setup will continue to evolve as part of the online leaderboard stage.

## Purpose

The purpose of this project is to create real-world challenges that provide a practical environment for learning and applying new concepts. 

I started the project with knowledge of C# and object-oriented programming. Instead of stopping after building the initial game, I kept expanding it into new areas that I wanted to learn.

The project has therefore become a long-term learning process:

**Game Development → Database Integration → Graphical UI → Online Functionality**

Each stage has introduced new problems to solve and new concepts to understand.

## What I Learned

One of the most valuable parts of this project has been the process of learning through implementation.

I try to understand the problems I encounter instead of simply looking for the quickest solution. When I get stuck, I research, experiment, and then implement what I have learned.

The transition from the console version to Windows Forms was especially challenging. Adapting the game loop to a graphical, event-driven environment required me to approach the existing game in a different way. Animation, timing, input, coordinates, and game state all had to work together in a new environment.

I also learned SQL and MySQL from the beginning of that part of the project and learned how database operations can be connected to application logic.

The graphical assets were created with AI assistance and then manually edited, organized, and integrated into the game. The source code, however, was written by me. I used AI as a learning and debugging tool rather than having it write the code for me.

The most important result of this project for me is not just the game itself, but how much I learned while building it.

## Development

The project has been developed over approximately two months, alongside a move to another country for school.

It is still an ongoing project. I plan to continue improving the same project and complete the final stage of the roadmap: the online leaderboard.
