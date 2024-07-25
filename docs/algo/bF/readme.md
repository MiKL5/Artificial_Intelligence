# **L'algorithme de Bellman-Ford**
L'algorithme de Bellman-Ford est un algorithme permettant de calculer les plus courts chemins depuis un sommet source donné dans un graphe orienté pondéré. Il a été nommé d'après ses inventeurs, Richard Bellman et Lester Ford Jr., qui l'ont publié respectivement en 1958 et 1956.

Principales caractéristiques de l'algorithme de Bellman-Ford :

Il peut gérer des graphes avec des poids d'arêtes négatifs, contrairement à l'algorithme de Dijkstra qui ne peut pas.
Il peut détecter l'existence de cycles de poids négatif dans le graphe, ce qui n'est pas possible avec l'algorithme de Dijkstra.
Sa complexité en temps est en O(|V||E|), où |V| est le nombre de sommets et |E| le nombre d'arêtes, ce qui le rend plus lent que l'algorithme de Dijkstra pour les graphes denses.
Fonctionnement de l'algorithme :

Initialisation : la distance du sommet source est mise à 0, et la distance de tous les autres sommets est initialisée à l'infini.
Relaxation des arêtes : l'algorithme répète |V|-1 fois le processus de relaxation des arêtes. La relaxation consiste à mettre à jour la distance d'un sommet si on trouve un chemin plus court pour y accéder.
Détection des cycles négatifs : après les |V|-1 itérations de relaxation, l'algorithme effectue une dernière itération. S'il y a encore des mises à jour de distance, cela signifie qu'il existe un cycle de poids négatif accessible depuis le sommet source.
L'algorithme de Bellman-Ford est donc très utile pour trouver les plus courts chemins dans des graphes avec des poids négatifs, et pour détecter l'existence de cycles négatifs, ce qui n'est pas possible avec l'algorithme de Dijkstra