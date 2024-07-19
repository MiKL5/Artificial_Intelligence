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
## **Les variantes ou améliorations de cet algorithme**
1. L’algorithme de Kahn amélioré : Une variante de l’algorithme de Kahn consiste à maintenir une liste des sommets sans prédécesseur, plutôt que de les rechercher à chaque itération. Cela permet de réduire la complexité en temps de l’algorithme de O(|V| + |E|) à O(|E|). [1]
2. L’algorithme de Tarjan : Cet algorithme utilise une approche basée sur la recherche en profondeur (DFS) pour trouver un tri topologique. Il est plus efficace que l’algorithme de Kahn dans certains cas, notamment lorsque le graphe est très dense. Sa complexité en temps est également en O(|V| + |E|). [1]
3. L’algorithme de Kahn parallélisé : Des versions parallélisées de l’algorithme de Kahn ont été proposées, permettant d’exploiter le parallélisme pour accélérer le calcul du tri topologique, notamment sur des graphes de grande taille. Ces variantes ont une complexité en temps réduite par rapport à l’algorithme séquentiel. [2]
4. L’algorithme de Kahn robuste aux erreurs : Certaines variantes de l’algorithme de Kahn ont été développées pour le rendre plus robuste aux erreurs, comme la présence de cycles dans le graphe. Ces versions modifiées peuvent détecter les cycles et fournir un résultat partiel ou signaler l’impossibilité d’obtenir un tri topologique. [2]
5. L’algorithme de Kahn incrémental : Des versions incrémentales de l’algorithme de Kahn ont été proposées, permettant de mettre à jour le tri topologique lorsque le graphe est modifié (ajout ou suppression de sommets/arêtes), sans avoir à recalculer entièrement le tri. Cela peut être utile dans des applications où le graphe évolue dynamiquement. [2]

_**⟹ Bien que l’algorithme de Kahn soit déjà efficace et largement utilisé, des variantes et améliorations ont été développées pour le rendre encore plus performant, notamment en termes de complexité temporelle, de parallélisation et de robustesse aux erreurs.**_