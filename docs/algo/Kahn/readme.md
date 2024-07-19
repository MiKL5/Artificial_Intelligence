# **L’algorithme de Kahn**
L’algorithme de Kahn est une méthode utilisée pour ordonner les sommets d’un graphe orienté acyclique (DAG) dans un ordre linéaire tel que pour chaque arête dirigée du sommet A vers le sommet B, A apparaisse avant B dans l’ordre.

## Les étapes
1. Trouver tous les sommets sans arête entrante (les sommets sources) et les ajouter dans un ensemble S.
2. Tant que l’ensemble S n’est pas vide :
    * Retirer un sommet n de S ;
    * Ajouter n à la liste L (qui contiendra l’ordre topologique) ;
    * Pour chaque sommet m avec une arête de n vers m :
        * Supprimer cette arête du graphe :
        * Si m n’a plus d’arête entrante, l’ajouter à S.
3. Si le graphe a encore des arêtes, cela signifie qu’il contient au moins un cycle, donc un tri topologique est impossible. Sinon, retourner la liste L qui contient l’ordre topologique.

Cet algorithme a une complexité en temps linéaire O(|V| + |E|), où |V| est le nombre de sommets et |E| le nombre d’arêtes du graphe.

L’algorithme de Kahn est l’un des deux principaux algorithmes pour effectuer un tri topologique, l’autre étant basé sur une recherche en profondeur (DFS).