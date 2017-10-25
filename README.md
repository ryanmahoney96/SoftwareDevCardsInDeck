# SoftwareDevCardsInDeck

Ryan M and Eddie M

This homework asks you to use test driven development and pair programming to create a framework for creating card games. You must write all code with your programming partner at your side. Each person should take turns being driver and co-pilot. Before you write production code you must write the tests that exercise that code. The tests should drive the development of the classes. In addition, you and your programming partner must use version control and github. Make sure to use a separate branch for development and the driver commits at regular intervals.

Requirements:
Create two related classes for playing card games. The data needed to be stored for a card is a numeric value and a suit. A card is responsible for being able to display itself. For example, when we want to display a two of hearts, ten of diamonds, jack of clubs, or ace of spades the output would look like this:

2 of Hearts
10 of Diamonds
J of Clubs
A of Spades

There should be a unit test class for the Card class that drives its development. 

Next, create a deck class. A deck is a collection of fifty-two cards. Each card is unique. There should be a card with a numeric value from two to the ace in each of the four suits. The responsibilities of the deck class are that it must be able to shuffle itself and deal out some number of cards from the deck. To shuffle the deck you will need to randomly move cards around in the deck.

When dealing out cards we will ask the deck for some number of cards. If there are enough cards in the deck it should deal those cards out. Once a card is dealt from the deck it cannot be dealt again from the same deck. If there aren't enough cards in the deck throw an exception.

There should be a unit test class for the Deck class that drives its development.

Next, create a class that allows one to manage players called 'Table'. The table has a deck of cards and some number of players at it. Each player can be dealt an equal number of cards.

There should be a unit test class for the Table class.