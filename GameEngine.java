/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.dylan_cahu.pendu;

/**
 *
 * @author Utilisateur
 */
import java.util.Scanner;

public class GameEngine {
    public static int wrongGuesses = 0;
    public static int maxWrongGuesses = 6;
    public static int goodGuessesCount;
    public static String word = getStartWord();
    public static boolean[] guessedTab = new boolean[word.length()];

    public static String getStartWord() {
        return "test";
    }

    public static boolean checkGuess(char guess) {
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

public static String getMaskedWord() {
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
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Guess the word!");
            System.out.println("You have " + (maxWrongGuesses - wrongGuesses) + " guesses left.");
            System.out.println("Current status: " + getMaskedWord());
            System.out.print("Enter your guess: ");
            char guess = scanner.next().charAt(0);

            checkGuess(guess);
        }
    }
}
