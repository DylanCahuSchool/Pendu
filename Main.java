/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package com.dylan_cahu.pendu;

import java.util.Scanner;

/**
 *
 * @author Utilisateur
 */
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        GameEngine game = new GameEngine();
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("Guess the word!");
            System.out.println("You have " + (game.maxWrongGuesses - game.wrongGuesses) + " guesses left.");
            System.out.println("Current status: " + game.getMaskedWord());
            System.out.print("Enter your guess: ");
            char guess = scanner.next().charAt(0);

            game.checkGuess(guess);
        }
    }
}