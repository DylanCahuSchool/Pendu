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
    public boolean isWin = false;
    public boolean isLose = false;
    public boolean canPlay = true;
    
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
                canPlay = false;
                isWin = true;
            }
        } else {
            wrongGuesses++;
            

            if (wrongGuesses == maxWrongGuesses) {
                canPlay = false;
                isLose = false;
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
}