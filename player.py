import math
import random

class Player:
    def __init__(self, letter):
        # letter is either 'x' or 'o'
        self.letter = letter

    # we want all player to get their nect move given in a game
    def get_move(self, game):
        pass

class RandomComputerPlayer(Player):
    def __init__(self,letter):
        super().__init__(letter)

    def get_move(self, game):
        pass

class HumanPlayer(Player):
    def __init__(self,letter):
        super().__init__(letter)

    def get_move(self, game):
        pass