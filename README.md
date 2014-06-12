Challenge of Dragon (CoD)
=========================

A TBS game with oriental background.

Setting
-------
Challenge of Dragon (CoD) takes place in very interesting period called Yuan-Ming Transition(원명교체기, 한자). This period is generally considered from AD 1355 to AD 1368 (14 years). CoD extends this period from AD 1255 to AD 1468 (214 years) to enhance the narrative and the gameplay. In this extended Yuan-Ming Transition, the rise and fall of Chinese Middle Kingdoms and the diplomacy and the warfare between outside countries and Chinese Middle Kingdoms is richly modeled and simulated by CoD. Historical events will include extensive real history events and virtual history events. There will be many *what-if* scenarios in CoD, so it can give the players a lot of replayability.

Basic Mechanism
---------------
In contrast to many other Turn-Based Strategy (TBS) games or Strategic Role-Playing Games (SRPG), CoD is focused on *the clan* instead of *the country*. It means that you can be a clan leader such as Zhang Sanfeng(장삼봉, 한자) and change the course of history beside the curtain.
CoD is mainly designed as a single-player game, but by the nature of TBS game and the server-client architecture, it can be easily expanded into a multi-player game.

Layers
------
CoD comprises three layer of gameplay mechanism, which are the country layer, the clan layer, and the private layer. Each layer can interact with other layer to a certain degree, but the main gameplay actions are inside each layer.

In the country layer, CoD depicts strategic warfares, tactical battles, diplomacy and intrigues between kingdoms using various mathematical models and computer simulations. Choosing the side is very important for any clan because the countries will have tremendous positive and negative effects on both the clan layer and the private layer. Political marriage, alliance, betrayal, raging a city... Almost every big historical event also occurs in the country layer.

The main game actions such as clan management, clan battle, and making contracts with private companies happen in the clan layer. The player assumes the leadership of a clan. The player should manage the economic, military, political, and diplomatic aspects of the clan.  

Combat
------
In general, CoD does not introduce the probability and random elements into the battle. In all three layers, there will be different type of battles, but all of them will have deterministic approach in terms of resolving the result of battles.
The reason of this design decision is very simple and clear. Excessive use of random chances can frustrate the player very easily.
Countering opponent's tactics is also one of the most important aspects of strategy games. However, if countering power (counter ratio?) is too big like 4x or 10x, then whole meta-game will go to excessive rock-paper-scissors alternating tactics. It will be no different than RPS. On the contrary, if countering power is too small like 1.01x or 1.05x, then spending time to research about counter relationship of various tactics will be useless. And there will be no *strategy* at all. So, having appropriate counter ratio is very important when designing a tactical battle.
Branching factor of tactics is also important. If a player can employ 300++ tactics and there are no big difference between them, he will get bored pretty fast. In contrast, if he can employ only 1~2 tactics at a time and that two tactics is completely opposite, then he will feel that he is being forced too much by the game design. Presenting 3~6 different choice of tactics at a time is crucial to give the player fun and freedom.