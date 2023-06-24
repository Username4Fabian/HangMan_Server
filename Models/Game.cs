using System;
using System.IO;
using System.Collections.Generic;
using  Hangman_Server.Models;


class Game{

public static String Test(){
    RandomWordGenerator WordGenerator = new RandomWordGenerator();
    string word = WordGenerator.getWord();
    return word;
}





}