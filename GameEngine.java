/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.dylan_cahu.pendu;

/**
 *
 * @author Utilisateur
 */
public class GameEngine {
    
    public  int wrongGuesses = 0;
    public  int maxWrongGuesses = 6;
    public  int goodGuessesCount;
    public  String word = getStartWord();
    public  boolean[] guessedTab = new boolean[word.length()];

    public  String getStartWord() {
        return "test";
    }

    public  boolean checkGuess(char guess) {
        if (word.contains(String.valueOf(guess))) {
            for (int i = 0; i < word.length(); i++) {
                if (word.charAt(i) == guess) {
                    goodGuessesCount++;
                    guessedTab[i] = true;
                }
            }

            if (goodGuessesCount == word.length()) {
                System.out.println("Congratulations! You win!");
                System.exit(0); // End the program after winning
            }
        } else {
            wrongGuesses++;
            System.out.println("Incorrect!");

            if (wrongGuesses == maxWrongGuesses) {
                System.out.println("You lose! The word was: " + word);
                System.exit(0); // End the program after losing
            }
        }
        return word.contains(String.valueOf(guess));
    }

public  String getMaskedWord() {
    StringBuilder maskedWord = new StringBuilder();
    for (int i = 0; i < word.length(); i++) {
        char c = word.charAt(i);
        if (c == ' ' || guessedTab[i] == true) {
            maskedWord.append(c);
        } else {
            maskedWord.append('*');
        }
    }
    return maskedWord.toString();
}

    public void main(String[] args) {
 
}
}
