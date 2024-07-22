## **Les principales différences entre l’algorithme de Kahn et celui de Tarjan pour le tri topologique**
1. L’objectif  
   * L’algorithme de Tarjan n’est pas conçu spécifiquement pour le tri topologique, mais plutôt pour la recherche des composantes fortement connexes d’un graphe. En revanche, l’algorithme de Kahn est dédié au tri topologique. [1]
2. L’approche  
   * L’algorithme de Kahn utilise une approche itérative, en identifiant à chaque étape les sommets sans prédécesseur, les supprimant du graphe, et en mettant à jour les degrés entrants des sommets voisins. [2]
   * L’algorithme de Tarjan utilise une approche récursive basée sur un parcours en profondeur du graphe, en attribuant des dates d’entrée et de sortie aux sommets. [2]
3. La complexité :
   * L’algorithme de Kahn a une complexité en O(|V| + |E|), où |V| est le nombre de sommets et |E| le nombre d’arêtes. [1]
   * L’algorithme de Tarjan a également une complexité en O(|V| + |E|), mais est généralement plus lent que celui de Kahn en pratique. [1]
4. L’unicité du résultat  
   * L’algorithme de Kahn peut produire plusieurs ordres topologiques différents, car il n’y a pas d’unicité dans le choix des sommets sans prédécesseur à chaque étape. [2]
   * L’algorithme de Tarjan produit toujours le même ordre topologique, car il se base sur l’ordre de fin de visite des sommets lors du parcours en profondeur. [2]
 
_**⟹  L’algorithme de Kahn est plus efficace et plus simple à mettre en œuvre que celui de Tarjan pour le tri topologique, mais ce dernier a l’avantage de produire un ordre topologique unique.**_