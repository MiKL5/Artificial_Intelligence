# L’alogrithme de recherche Tabou

C’est une métaheuristique d’optimisation combinatoire très puissante. Voici le fonctionnement général de cet algorithme :

1. Initialisation : On part d’une solution initiale réalisable.
1. Exploration du voisinage : À chaque itération, on explore le voisinage de la solution courante, c’est-à-dire l’ensemble des solutions qui peuvent être obtenues à partir de la solution courante par une petite modification.
1. Sélection de la prochaine solution : Parmi les solutions du voisinage, on choisit la meilleure solution (en termes de la fonction objectif) qui n’est pas dans la liste tabou. La liste tabou contient les solutions récemment visitées qu’on interdit de revisiter pendant un certain nombre d’itérations.
1. Mise à jour de la liste tabou : Après avoir sélectionné la prochaine solution, on met à jour la liste tabou en y ajoutant la solution courante et en retirant les solutions les plus anciennes.
1. Critère d’arrêt : L’algorithme s’arrête lorsqu’un certain critère d’arrêt est satisfait, par exemple après un nombre maximal d’itérations ou lorsqu’aucune amélioration n’a été trouvée depuis un certain nombre d’itérations.

La recherche tabou est très efficace car elle permet d’explorer intelligemment l’espace des solutions en évitant de revisiter des zones déjà explorées, ce qui améliore grandement la convergence vers un optimum global. C’est une méthode très utilisée pour résoudre des problèmes d’optimisation combinatoire complexes.