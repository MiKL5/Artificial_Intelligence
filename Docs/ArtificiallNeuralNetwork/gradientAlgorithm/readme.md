# Algorithme du gradient

"Ce chapitre détail la mise à jour des poids"

Dans un réseau simple de neurone, il y a une valeur d'entrée `X1` (et un seul poids `W1`) , va au neurone caché avec la fonction d'activation et directement la fonction de coup permet de calculer une valeur de sortie.  
L'objectif et de trouver avec le seul poids la meilleure valeur de sortie possible.

## Comment minimiser la fonction de coup ?

1. Il est possible de calculer cette fonction de coup pour plein de valeur différente. À chaque itération le poids et y chapeau. ça génère plutôt un graphique parabolique. La meilleure valeur serait à peu près au milieu. C'est **la technique de brute force**. _ça fonctionne bien quand il y a qu'un seul poids_.  
Cependant quand il y a plus de poids (synapses), ça provoque **`le fléau de la dimension`[¹]**

2. Heureusement, il y a une solution beaucoup plus intelligente. En calculant une dérivée, puis tassant une tangente, il en résulte la pente, le signe de la pente détermine l'inclinaison. Si la pente en négative, il faut aller vers la droite, si elle est positive, vers la gauche ; l'idée est d'aller du côté où ça descend. L'agent observe ainsi l'angle d'inclinaison de la courbe.  
L'IA essaye sur la droite, puis sur la gauche, réessaye un peu plus à droite, et ainsi jusqu'à un résultat satisfaisant. Après quelque itération l'agent trouve les meilleurs poids qui optimises les réseaux de neurones. C'est l'**algorithme du gradient**. C'est le principe d'agir step by step en itérant jusqu'à ce qu'il soit impossible de descendre.

___
[¹]Le fléau de la dimension :  
Si le réseau n'est pas entraîné, il y a 25 poids (synapses) et supposons que l'agent essai 1000 valeurs, afin de voir toutes les combinaisons possibles, ça fait 1000 x 1000 x 1025, soit 10^75 combinaisons.  
En utilisant l'ordi le plus puissant au monde (capable de calculer 93 pétaflops[²] [^3], 93x10 puissance 15 opérations par seconde). Partant de l'hypothèse simpliste qu'une combinaison représente une opération, ça durerait 1,08x10^58 secondes, soit en années 3,42x10^50 années (vraisemblablement plus long que l'âge de l'univers). 
En conclusion l'ordi le plus puissant du monde ne peut pas entraîner ce réseau de neurone assez simple. 

[²]Un flop :  
Flotting operation per second, à savoir le nombre d'opération possible par seconde.  

[^3]Peta :  
Puissance 15.