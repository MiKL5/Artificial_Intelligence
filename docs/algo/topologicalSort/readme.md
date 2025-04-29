# **L’algo de parcours de graph en profondeur `tri topologique`** <a href="../../"><img src="../../../assets/images/ai1.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
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
#### Exemple de tri topologique avec un graph acyclique dirigé
```
     A
    / \
   B   C
  / \ /
 D   E
```
Ordre topologique est
1. D
2. B
3. E
4. A
5. C

Cet ordre respecte bien les dépendances entre les nœuds ; chaque nœud apparaît avant ceux qui dépendent de lui.

Les applications du tri topologique incluent  
* Ordonnancement de tâches avec des dépendances
* Compilation de programmes avec des dépendances de modules
* Analyse d’analyse de flux de données dans les réseaux
* Détection de cycles dans les réseaux

L’algorithme de tri topologique a une complexité en temps de O(|V| + |E|), où |V| est le nombre de nœuds et |E| le nombre d’arêtes du graphe.
## **Existe-t-il des variantes ou des améliorations de l’algorithme de tri topologique pour des graphes avec des propriétés spécifiques ?**
1. **Le tri topologique avec poids**  
    Dans certains cas, les arêtes du graphe peuvent avoir des poids (valeurs) associés, représentant par exemple des priorités ou des délais.  
    Des variantes de l’algorithme de tri topologique permettent de prendre en compte ces poids pour déterminer un ordre optimal en fonction de ces priorités.
1. **Le tri topologique parallèle**  
    Pour accélérer le tri topologique sur de très grands graphes, des versions parallèles de l’algorithme ont été développées.  
    Elles permettent d’exploiter plusieurs processeurs ou cœurs de calcul pour traiter simultanément différentes parties du graphe.
1. **Le tri topologique incrémental**  
    Lorsque le graphe est sujet à des modifications fréquentes (ajouts/suppressions de nœuds/arêtes), un tri topologique incrémental peut être utilisé.  
    Il met à jour l’ordre topologique de manière efficace en ne recalculant que la partie affectée par les changements, plutôt que de refaire le tri complet.
1. **Le tri topologique sur des graphes avec propriétés particulières**  
    Certaines variantes existent pour des graphes ayant des caractéristiques spécifiques, comme les graphes de co-dépendance, les graphes de flux de données, ou les graphes avec des contraintes temporelles.  
    Ces variantes exploitent les propriétés du graphe pour optimiser le tri topologique.
1. **Le tri topologique approché**  
    Lorsque le graphe est très grand et qu’un tri topologique exact est trop coûteux, des algorithmes d’approximation peuvent être utilisés.  
    Fournissant un ordre topologique proche de l’optimal, mais de manière plus rapide.

_**⟹ Ces différentes variantes permettent d’adapter l’algorithme de tri topologique à des besoins spécifiques, tout en conservant sa complexité temporelle linéaire O(|V| + |E|) dans la plupart des cas.**_
## **C’est un algo de parcours de graph en profondeur**
Le tri topologique est précisément un algorithme de parcours en profondeur (DFS - Depth-First Search) appliqué aux graphes dirigés acycliques (DAG - Directed Acyclic Graph).

### Les principales caractéristiques du tri topologique :

1. Type d’algorithme :
    * Algorithme de parcours de graphe
    * Algorithme de parcours en profondeur (DFS)
2. Propriétés du graphe :
    * Le graphe doit être dirigé (chaque arête a une direction)
    * Le graphe doit être acyclique (il ne doit pas y avoir de cycles)

Le principe du tri topologique est le suivant :
1. Effectuer un parcours en profondeur (DFS) du graphe dirigé acyclique.
1. Lors du parcours, empiler les nœuds dans l’ordre inverse de leur fin de visite.
1. L’ordre final des nœuds dans la pile représente un tri topologique valide du graphe.

Cet algorithme permet de trouver un ordre linéaire des nœuds du graphe tel que pour chaque arête dirigée (u, v), le nœud u apparaît avant le nœud v dans l’ordre.

_**⟹ Le tri topologique a de nombreuses applications, notamment dans la gestion de dépendances, la planification des tâches, l’ordonnancement de processus, l’analyse de flux de données, etc.**_