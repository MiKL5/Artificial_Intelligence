# **L’algorithme de tarjan** <a href="../../"><img src="../../../assets/images/ai1.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
L’algorithme de Tarjan est une méthode efficace pour trouver les composantes fortement connexes (CFC) d’un graphe orienté.  
Il a été développé par le mathématicien américain Robert Tarjan en 1972.

Voici les principales caractéristiques de cet algorithme :
1. **La complexité linéaire**  
   L’algorithme de Tarjan s’exécute en temps linéaire par rapport à la taille du graphe (nombre de sommets et d’arêtes), ce qui en fait une solution très efficace.
2. **Parcours en profondeur**  
   L’algorithme utilise un parcours en profondeur (DFS) du graphe pour identifier les CFC. Il maintient une pile des sommets visités.
3. **Le calcul des indices de découverte et de bas-niveau**  
   Chaque sommet se voit attribuer un indice de découverte (quand il est visité pour la première fois) et un indice de bas-niveau (le plus petit indice de découverte atteignable depuis ce sommet et ses descendants).  
   Ces indices permettent d’identifier les racines des CFC.
5. **L’identification des CFC**  
   Lorsqu’un sommet a un indice de bas-niveau égal à son indice de découverte, c’est la racine d’une CFC. Tous les sommets au-dessus de ce sommet dans la pile forment alors une CFC.
6. **Le tri topologique implicite**  
   L’ordre dans lequel les CFC sont identifiées constitue un tri topologique inverse du graphe des CFC.

_**⇒ l’algorithme de Tarjan est une solution élégante et efficace pour trouver les composantes fortement connexes d’un graphe orienté, avec de nombreuses applications en théorie des graphes.**_