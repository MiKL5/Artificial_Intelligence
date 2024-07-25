# **L’algorithme de Prim**
C’est un _algorithme glouton_ qui permet de calculer un arbre couvrant minimal (ACM) dans un graphe connexe pondéré et non orienté. Autrement dit, il trouve un sous-ensemble d’arêtes formant un arbre qui couvre tous les sommets du graphe initial, tout en minimisant la somme des poids de ces arêtes.

## **Principales étapes de l’algorithme**
1. Choisir un sommet initial arbitrairement et l’ajouter à l’ACM.
1. Sélectionner l’arête de poids minimum qui relie un sommet inclus dans l’ACM et un sommet non inclus, puis ajouter cette arête et le nouveau sommet à l’arbre.
1. Répéter l’étape 2 jusqu’à ce que tous les sommets soient inclus dans l’arbre couvrant minimal.

Il fait croître progressivement l’arbre à partir d’un sommet initial, en ajoutant à chaque étape l’arête de poids minimum qui relie un sommet déjà dans l’arbre à un sommet en dehors. Cela garantit que l’arbre obtenu à la fin est bien un arbre couvrant minimal.

La complexité de l’algorithme dépend de la structure de données utilisée pour stocker les sommets et gérer les priorités. Avec une file de priorité binaire, la complexité est en `O(n log n + m log n)`, où n est le nombre de sommets et m le nombre d’arêtes du graphe.

L’algorithme de Prim a de nombreuses applications pratiques, notamment dans la conception de réseaux de télécommunications, la planification des transports ou l’analyse de structures moléculaires. C’est l’un des algorithmes les plus utilisés pour résoudre le problème de l’arbre couvrant minimal.