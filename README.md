# 🛡️ The Last Guardian – Text-Based Console Game

![Status](https://img.shields.io/badge/status-Under%20Development-yellow)
![Language](https://img.shields.io/badge/language-C%23-blue)

---

## 📖 About the Project

This project is part of a **programming assignment** where the goal was to create a **mini text-based adventure game** in the console.  
While the original task was called **"Mini Adventure"**, I have chosen to name my version of the game **_The Last Guardian_**.

The game starts with the player choosing a username and a class (e.g., **Warrior** or **Mage**).  
The chosen class affects starting values such as **HP**, **damage**, and possibly **mana**.  

The player can then:  
- Go on adventures and encounter random enemies  
- Rest to regain some HP  
- View player status  
- Exit the game  

Combat consists of **simple turn-based battles**: the player chooses an action (e.g., *Attack, Heal, Run*), and the enemy strikes back if it’s still alive.  
If the player wins, they earn gold; if HP reaches **0**, the game is **over**.

---

## ✅ Assignment Requirements

For the project to be approved, the program must meet **all** of the following points:

### 1. Variables
- Use variables for player data: username, class, HP/MaxHP, damage, gold (and possibly mana).
- Use variables for enemy stats: HP, damage, and gold reward.

### 2. Conditions
- Use `if/else` or `switch` statements for decisions  
  *(e.g., class selection, menu options, combat actions, and results).*

### 3. Loops
- A **main game loop** (runs until the player dies or chooses to quit).
- A **combat loop** (runs until either the player or the enemy reaches 0 HP).

### 4. Arrays
- At least **one array** must be used in the game  
  *(e.g., list of enemy names or possible actions/loot).*  
- Use the array in the game logic  
  *(e.g., randomly selecting an enemy or displaying options).*

### 5. Methods
Create **at least three methods** with clear names and purposes, such as:  
- A method to display status  
- A method to create/randomize an enemy  
- A method to handle the player’s turn  
- A method to handle the enemy’s turn

### 6. Simple Classes
- Create a **Player** class with fields: name, class, HP/MaxHP, damage, gold.
- Create an **Enemy** class with: name, HP, damage, gold reward.

### 7. Input / Output
- Provide clear instructions and read the player's input.
- Show the result after each action  
  *(e.g., damage dealt, remaining HP, victory/defeat).*

### 8. Structure & Readability
- Use clear method names.
- Use meaningful variable names.
- Keep indentation clean.
- Add short comments where necessary.

---

## 🛠️ Recommended Development Steps

1. **Start & Player Data**  
   Ask for the username → let the player choose a class (e.g., Warrior/Mage) → set starting values.

2. **Enemy Array**  
   Create an array of enemy names *(e.g., Rat, Goblin, Skeleton, Bandit)*.

3. **Main Menu (Loop)**  
   Show options: **Adventure**, **Rest**, **Status**, **Quit**.  
   Keep looping until the player dies or quits.

4. **Adventure**  
   Randomly select an enemy → give it reasonable stats *(HP, damage, gold reward)*.

5. **Combat Loop**  
   Player chooses an action *(Attack, Heal, Run)* → enemy attacks if alive → repeat until someone’s HP = 0.

6. **Reward or Defeat**  
   - Victory → player earns gold.  
   - Defeat → **Game Over**.

7. **Rest**  
   Restore a small amount of HP, up to MaxHP.

8. **Status**  
   Display player's name, class, HP/MaxHP, damage, and gold.

9. **Methods**  
   Move clear game logic parts into methods *(status, create enemy, player turn, enemy turn)*.

10. **Final Adjustments**  
    Test everything → improve texts → make sure all requirements are met.

---

## 🏆 Grading Criteria

- **Pass** ✅ – All requirements are fulfilled, the program runs without crashing, and the game flow is clear.  
- **Fail** ❌ – One or more requirements are missing, the program crashes immediately, or the game flow is unclear.

---

## 📤 Submission

- Upload your code to **GitHub** and submit the repository link.

---

## 💡 Optional Improvements *(Not Graded)*

- Increase difficulty gradually after each win *(slightly stronger enemies)*.
- Add a simple **heal limitation** *(e.g., can only be used every other round)*.
- Add a small array of **loot messages** to make rewards more varied.

---

## 🚧 Project Status

> **The Last Guardian** is **currently under development**.  
> New features and improvements will be added continuously.

---
