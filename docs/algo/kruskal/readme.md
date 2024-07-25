# **L’algorithme de Kruskal**
L’algorithme de Kruskal est une méthode efficace pour trouver l’arbre couvrant de poids minimum (ACPM) dans un graphe connexe non orienté et pondéré. Il a été conçu en 1956 par le mathématicien américain Joseph Kruskal.

## Principales étapes de l’algorithme
1. Trier les arêtes du graphe par ordre croissant de poids, afin d’identifier facilement les arêtes les moins coûteuses.
2. Initialiser un ensemble vide qui contiendra les arêtes de l’ACPM.
3. Parcourir les arêtes triées dans l’ordre croissant des poids :
    * Si l’ajout de l’arête courante ne crée pas de cycle dans l’ensemble d’arêtes sélectionnées jusqu’à présent, alors ajouter cette arête à l’ensemble.
    * Sinon, ignorer cette arête.
4. Répéter l’étape 3 jusqu’à ce que toutes les arêtes aient été examinées ou que l’ensemble contienne n-1 arêtes, où n est le nombre de sommets du graphe.

## **Les avantages**
Il est simple à mettre en œuvre.
Il garantit de trouver l’ACPM optimal.
Sa complexité est en `O(E log E)`, où `E` est le nombre d’arêtes du graphe, ce qui le rend efficace même pour de grands graphes.

_**⟹ L’algorithme de Kruskal trouve de nombreuses applications pratiques, notamment dans la conception de réseaux de télécommunications, de circuits électroniques, en bioinformatique et en recherche opérationnelle.**_