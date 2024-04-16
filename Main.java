/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package com.dylan_cahu.pendu;

/**
 *
 * @author Utilisateur
 */
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        GameEngine game = new GameEngine();

    
        while (true) {


        System.out.println("Guess the word!");
        System.out.println("You have " + (game.maxWrongGuesses - game.wrongGuesses) + " guesses left.");
        System.out.println("Current status: " + game.getMaskedWord());
        System.out.print("Enter your guess: ");
        char guess = scanner.next().charAt(0);

        if (game.checkGuess(guess) == false) {
            System.out.println("Incorrect!");
        } else {
            System.out.println("Correct!");
        }

        if (game.canPlay == false && game.isLose) {
            System.out.println("You lose! The word was: " + game.word);
            System.exit(0); // End the program after losing
        } else if (game.canPlay == false && game.isWin) {
            System.out.println("Congratulations! You win!");
            System.exit(0); // End the program after winning
        }

    }
}
}
