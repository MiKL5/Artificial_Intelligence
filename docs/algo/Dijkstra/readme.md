# **L’algorithme de parcours de Dijkstra**
L’algorithme de Dijkstra est un algorithme permettant de trouver le plus court chemin entre un nœud de départ et tous les autres nœuds d’un graphe pondéré. Il est particulièrement efficace pour les graphes où les poids des arêtes sont positifs.

## **Les étapes de l’algorithme**
1. L’initialisation  
Consiste à attribuer une distance infinie à tous les nœuds, sauf le nœud de départ auquel on attribue une distance de 0.  
Puis, marquer tous les nœuds comme “non visités”.
1. Sélection du nœud suivant  
Parmi les nœuds non visités, sélectionner le nœud avec la distance la plus faible.  
Marquer ce nœud comme “visité”.
1. Mise à jour des distances  
Pour chaque nœud voisin du nœud sélectionné  
* Calculer la distance depuis le nœud de départ en passant par le nœud sélectionné.
* Si la distance est plus faible que la distance actuellement enregistrée pour ce nœud voisin ; mettre à jour la distance.
4. Répéter les étapes 2 et 3 tant que tous les nœuds aient été visités.
```statao
Fonction Dijkstra(graphe, nœud_départ):
   Initialiser un tableau "distances" avec une distance infinie pour tous les nœuds, sauf le nœud de départ qui a une distance de 0
   Initialiser un tableau "précédents" avec une valeur null pour tous les nœuds
   Initialiser un ensemble "non_visités" avec tous les nœuds du graphe

   Tant que "non_visités" n'est pas vide :
        Sélectionner le nœud "u" dans "non_visités" avec la plus petite distance dans "distances"
        Retirer "u" de "non_visités"

        Pour chaque voisin "v" de "u" :
            Calculer la distance potentielle depuis le nœud de départ jusqu'à "v" en passant par "u"
            Si cette distance est plus petite que la distance actuellement enregistrée dans "distances" pour "v" :
               Mettre à jour la distance de "v" dans "distances"
               Mettre à jour le prédécesseur de "v" dans "précédents"

   Retourner le tableau "précédents" qui contient le plus court chemin depuis le nœud de départ jusqu'à chaque autre nœud
```
Cet algorithme a une complexité en temps de `O((|V| + |E|) log |V|)`, où `|V|` est le nombre de nœuds et `|E|` le nombre d’arêtes du graphe.
## **Les avantages**
1. **L’efficacité**  
   L’algorithme de Dijkstra a une complexité en temps de `O((|V| + |E|) log |V|)`, ce qui le rend relativement efficace pour les graphes de taille moyenne à grande.
2. **La simplicité**  
   L’algorithme de Dijkstra est assez simple à comprendre et à mettre en œuvre par rapport à certains autres algorithmes de recherche de plus court chemin.
3. **La robustesse**  
   L’algorithme fonctionne correctement pour des graphes avec des poids d’arêtes positifs, ce qui en fait un choix fiable dans de nombreuses applications.
4. **Le calcul de tous les plus courts chemins**  
   Dijkstra calcule le plus court chemin depuis un nœud de départ vers tous les autres nœuds du graphe, pas seulement vers un nœud de destination spécifique.
## **Les inconvénients**
1. **Le poids négatifs**  
   Cet algorithme ne fonctionne pas correctement lorsque le graphe contient des poids d’arêtes négatifs.  
   Dans ce cas, l’algorithme de ”`Bellman-Ford`” est plus approprié.
2. **Pas de prise en compte des contraintes**  
   Dijkstra ne tient pas compte de certaines contraintes comme la limite de capacité des arêtes ou les interdictions de circulation.  
   D’autres algorithmes comme ”`Kruskal`” ou ”`Prim`” peuvent être plus adaptés dans ces cas.
3. **Le calcul de tous les plus courts chemins**  
   Bien que ce soit un avantage dans certains cas, le fait de calculer tous les plus courts chemins peut être un inconvénient si on ne s’intéresse qu’à un seul chemin particulier. Dans ce cas, des algorithmes plus ciblés peuvent être plus efficaces.
4. **La sensibilité aux erreurs de données**  
   Se basant sur les poids des arêtes, toute erreur dans ces poids peut avoir un impact important sur le résultat final.

_**⟹ L’algorithme de Dijkstra est un choix pertinent pour de nombreuses applications de recherche de plus court chemin. Nonobstant il est limité selon le type de graphe et les contraintes à considérer.**_