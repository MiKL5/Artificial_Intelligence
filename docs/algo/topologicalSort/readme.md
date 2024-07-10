# **L’algo de parcours tri topologique**
Le tri topologique est un algorithme utilisé pour ordonner les nœuds d’un graphe acyclique dirigé (DAG, Directed Acyclic Graph) de manière à ce que chaque nœud apparaisse avant tous les nœuds qui dépendent de lui.

Les principales étapes de l’algorithme de tri topologique  
1. Identifier un graphe acyclique dirigé (DAG)  
    Le tri topologique ne peut être appliqué que sur des graphes sans cycle, car un cycle impliquerait une dépendance circulaire entre les nœuds, ce qui rendrait l’ordonnancement impossible.
2. Initialiser une liste vide pour stocker l’ordre topologique  
    Cette liste va contenir les nœuds du graphe dans l’ordre topologique.  
3. Identifier les nœuds sans prédécesseur (entrée)  
    Trouver tous les nœuds qui n’ont pas de nœud parent (pas de dépendances entrantes).  
    Ces nœuds peuvent être placés en tête de l’ordre topologique.
1. Ajouter ces nœuds sans prédécesseur à la liste d’ordre topologique.  
    Retirer ces nœuds du graphe en supprimant leurs arêtes sortantes.
1. Répéter les étapes 3 et 4 jusqu’à ce que tous les nœuds aient été ajoutés à la liste  
    À chaque itération, les nœuds sans prédécesseur restants sont ajoutés à la liste d’ordre topologique.  
    Leurs arêtes sortantes sont supprimées du graphe.
