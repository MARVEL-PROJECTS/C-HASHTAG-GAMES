 static void Main(string[] args)
        {
            Game game = new Game(args[0] != null ? args[0] : "jogo.txt");
            char c;
            game.renderBoard();

            while( !game.End ){

                while (Console.KeyAvailable == false)
                    Thread.Sleep(250); // Loop until input is entered.

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F2)
                {
                    game.showNewTip();
                }
                else if (char.IsLetter(key.KeyChar))
                {
                    c = key.KeyChar;

                    game.checkGuess(c);
                }

                game.renderBoard();
            }
        }
         private void newGame()
 {
     g = new Game();
     enter.Enabled = true;
     wordTextBox.Text = g.getDefaultUserGuessedWord();
     guessedLetters.Text = "";
     pictureBox1.Image = (Image)Hangman.Properties.Resources.ResourceManager.GetObject("_0");
 }
 