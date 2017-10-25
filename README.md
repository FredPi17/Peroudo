
1	Introduction
L’objectif du projet est de créer un jeu sous la forme d’une application (client lourd ou web).

Le jeu à implémenter est le jeu suivant : PERUDO


 


L’application devra permettre à un utilisateur humain de jouer contre d’autres humains ou contre l’ordinateur au travers d’une interface utilisateur.

 
2	Règles du jeu
Résumé

Chaque joueur jette des dés et ignore les résultats des autres joueurs. Le principe est que le joueur, ne connaissant que ses propres dés, doit faire des paris sur le nombre de dés au total ayant une certaine valeur. 

But du jeu

Etre le dernier joueur à avoir des dés dans sa main.
 
3	Déroulement du jeu
Chaque joueur a un certain nombre de dés à lancer. Ces dés sont des dés à six faces normales, excepté le 1, qu'on appelle Paco, et qui est une sorte de joker : il a toutes les autres valeurs à la fois. Ainsi, par exemple, si on a sur cinq dés Paco-deux-trois-cinq-cinq, on comptera 2 deux (le vrai et le Paco), 2 trois (le vrai et le Paco), 1 quatre (le Paco), 3 cinq (le Paco et les deux vrais), ou 1 six (le Paco).
Les enchères sur les faces des dés sont toujours au moins. Si on parie sur 5 six, il faut qu'il y ait au moins 5 dés de valeur six pour que l'enchère soit correcte.

3.1	Début
On tire d'abord aux dés qui va commencer. Chaque joueur prend ensuite possession d'un gobelet de cinq dés, puis secoue le gobelet et le pose à l'envers, de manière que les dés aient des valeurs aléatoires et restent sous le gobelet, donc invisibles (les gobelets sont opaques). Chaque joueur peut alors regarder sous son gobelet et uniquement le sien. Chaque joueur à tour de rôle, dans le sens des aiguilles d'une montre va pouvoir faire des enchères sur le nombre de dés d'une certaine valeur.

3.2	Déroulement d'une manche
Le premier joueur fait une enchère. Celle-ci ne doit pas porter sur le nombre de Pacos.
Le suivant peut :
•	Surenchérir 
o	En pariant plus de dés : sur 7 cinq, surenchérir à 9 cinq par exemple.
o	En pariant une plus grande valeur : sur 7 cinq, surenchérir à 7 six par exemple
o	En pariant le nombre de Pacos. Les Pacos étant statistiquement deux fois moins nombreux que les faces normales (Pacos inclus), on peut diviser par deux le nombre de dés pariés : sur 7 cinq, surenchérir à 4 Pacos par exemple (7/2=3,5 donc 4 Pacos)
o	Pour revenir d'une enchère sur les Pacos à une enchère normale, il faut multiplier par deux et ajouter un : sur 4 Pacos, surenchérir à 9 deux par exemple (4x2=8, et on ajoute 1).
•	Considérer que l'enchère est erronée (il y a moins de dés en réalité que le nombre annoncé). Dans ce cas il dit Dudo (prononcer Doudo) et tout le monde révèle ses dés. Si l'enchère était juste, le joueur qui a douté perd un dé, sinon c'est celui qui a fait l'enchère erronée qui en perd un.
3.3	Poursuite du jeu
Le nombre de dés pariés augmentant, il viendra fatalement un moment où l'enchère sera trop haute et où quelqu'un dira Dudo. Quelqu'un finira donc par perdre un dé. Commence alors une autre manche. Chacun relance ses dés et celui qui vient de perdre un dé recommence les enchères. Si celui qui vient de perdre un dé a perdu son dernier dé, il a perdu, et c'est le joueur suivant, dans le sens des aiguilles d'une montre, qui démarre.

3.4	Fin du jeu
Le jeu se termine quand tous les joueurs, sauf un (le vainqueur), ont perdu tous leurs dés.

3.5	Palifico
Le Palifico est un tour de jeu particulier, qui se produit quand un joueur vient de perdre son avant-dernier dé (il n'en a plus qu'un seul). Les règles sont alors modifiées pour cette manche-là uniquement : les Pacos ne sont plus des jokers et la valeur de dés enchérie par celui qui commence ne peut plus être changée. De plus, celui qui commence peut parier sur les Pacos, puisqu'ils sont alors des valeurs normales.
En résumé, le premier joueur annonce par exemple 2 cinq, et le suivant doit dire 3 cinq, 4 cinq ou plus ; ou dire Dudo. Seuls les cinq seront comptés, sans les Pacos.
.

 
4	Cahier des charges
4.1	Joueurs
Un joueur est identifié par:

-	Son nom
-	Son prénom
-	Son nom de joueur (pseudo)

4.2	Démarrage d’une partie
L’utilisateur devra pouvoir renseigner :
-	Le nombre de joueurs.
-	Le type des joueurs (humain ou ordinateur)
-	Les informations sur les joueurs humain
L’application devra alors démarrer la partie en prenant en compte les paramètres utilisateurs cités ci-dessus.
Les informations des joueurs seront sauvegardées pour pouvoir être préchargées lors d’une nouvelle partie. Lors du choix du type humain pour un joueur, une liste des joueurs déjà enregistrés sera alors propose à l’utilisateur afin qu’il puisse sélectionner un ancien joueur.
Une partie ne peut démarrer que s’il y a au minimum 1 joueur humain.
4.3	Déroulement d’une partie
L’écran de jeu permettra à l’utilisateur de jouer suivant les règles du jeu citées ci-dessus.
4.4	Statistiques
Un écran permettra à un utilisateur d’afficher les statistiques du jeu à savoir :
-	Nombre de parties
-	Nombre de manches par partie
-	Meilleurs joueurs
-	Statistiques par joueur
Les statistiques devront être persistés, même si l’application se coupe (crash ou fermeture volontaire de l’utilisateur).
A noter : Il peut être fait le choix d’utiliser une plateforme Analytics disponible sur le marché (gratuite). 
4.5	Export/Import
L’application devra pouvoir exporter ou importer une partie déjà démarrée.
4.5.1	Export
Exporter une partie en cours génèrera un fichier d’extension “.perudo”. L’utilisateur pourra saisir le chemin de sauvegarde du fichier pour l’exporter où il le souhaite sur son ordinateur.
4.5.2	Import
L’utilisateur pourra importer un fichier d’extension “.perudo” dans l’application.
L’import aura pour effet de démarrer une partie configurée par les données du fichier sélectionné par l’utilisateur.
4.5.3	Format d’échange du fichier
Il n’y a pas de format spécifique défini. Il peut s’agir d’un fichier texte ou binaire. 
5	Livrables
Sera attendu en fin de projet les livrables suivants :
-	Planning du projet
o	Dates définies
o	Informations sur l’avancée du projet (retards, difficultés rencontrées, …)
-	Code source de l’application, commenté. Il est préconisé d’utiliser github pour gérer la synchronisation des sources entre l’équipe.
-	Description des tests mis en place et exécutes.
-	Rétro sur le projet
o	Les choses qui se sont bien passées
o	Les choses qui se sont moins bien passes
o	Les choses qui pourraient améliorer le prochain projet
-	Présentation technique de la solution, au format PowerPoint
Une présentation orale sera organisée afin de présenter la solution.


Les livrables devront être fournies au moins 1 semaine avant la date de la présentation finale.
 
6	Présentation orale
La présentation orale devra contenir une présentation technique de la solution et une démo.

Durée de la présentation : 30 min.

6.1	Présentation technique
La présentation technique devra détailler les points suivants mis en œuvre dans l’application :
-	Technologies utilisées
WPF, version de .net, type de base de données, …)
-	Organisation du code
Mise en place d’un design pattern particulier – MVC, MVVM, …
Séparation du code dit “métier” du code lié à l’interaction avec l’utilisateur. Utilisation de librairies, …
6.2	Démo
La démo devra montrer l’application tourner en montrant les fonctionnalités.
A la fin de la démo, il faudra aussi effectuer la présentation de la retro du projet afin de partager les points bloquants/chauds et améliorations imaginées.
 
7	Barème de notation
La note finale sera basée sur la présentation orale qui sera faite en fin de projet.

Livrables demandés : 10 points
-	Délais tenus : 2 points
-	Qualité du code source : 4 points
-	Tests mis en place : 4 points

Présentation technique : 10 points.
-	Solution technique mise en place : 2 points
-	Stratégie de tests mis en place : 4 points
-	Framework spécifiques utilises : 4

Démo : 10 points.
-	Présentation des fonctionnalités : 8 points
Présentation des interfaces utilisateurs, démo, … Libre à vous de choisir ce qui peut être pertinent d’être présenté.
-	Rétro projet : 2 points.

La note globale, sur 30 points sera ramenée à une note sur 20.

En plus de cette note globale, une note personnelle sera appliquée. Cette note tiendra compte de la présentation orale de chacun, mais aussi de la capacité de chaque personne à faire avancer le projet (Gestion projet, mise en place de process, procédures de tests, pourcentage de code produit).

