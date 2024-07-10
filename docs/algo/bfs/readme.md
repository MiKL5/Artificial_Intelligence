# **L’algorithme de parcours en largeur BFS (Breadth-First Search)**
L’algorithme de parcours en largeur est une méthode itérative, niveau par niveau, servant à explorer sysématiquement un graphe ou un arbre. Il débute par un nœud source et explore ensuite tous ses voisins avant de passer aux voisins des voisins, et ainsi de suite.

1. Commencer à partir d’un nœud de départ (ou racine).
2. Marquer ce nœud comme “visité”.
3. Placer ce nœud dans une file d’attente.
4. Tant que la file d’attente n’est pas vide :  
   a. Retirer le premier élément de la file d’attente.  
   b. Examiner tous les nœuds voisins de cet élément.  
   c. Pour chaque nœud voisin non visité :  
        i. Le marquer comme “visité”. 
        ii. Le placer à la fin de la file d’attente.  
5. L’algorithme se termine lorsque tous les nœuds accessibles ont été visités.

Les principales caractéristiques du BFS sont :
* Exploration niveau par niveau du graphe ou de l’arbre.
* Utilisation d’une file d’attente pour garder trace des nœuds à visiter.
* Visite de tous les nœuds à une certaine distance du nœud de départ avant de passer aux nœuds plus éloignés.

Les applications typiques du BFS incluent :
* Trouver le plus court chemin entre deux nœuds dans un graphe non pondéré.
* Déterminer la connectivité d’un graphe.
* Résoudre des problèmes de labyrinthe ou de jeu.

Voici un exemple de code en pseudo-code de l’implémentation du BFS :
```ebnf
fonction BFS(graphe, noeud_depart):
    file ← nouvelle file
    noeud_depart.marquer_comme_visite()
    file.enfiler(noeud_depart)
    
    tant que file n'est pas vide:
        noeud_courant ← file.defiler()
        pour chaque voisin de noeud_courant:
            si voisin n'est pas visité:
                voisin.marquer_comme_visite()
                file.enfiler(voisin)
```
## **Les principaux avantages**
1. **La détection du plus court chemin**  
    Le BFS permet de trouver le plus court chemin entre le nœud de départ et n’importe quel autre nœud accessible dans un graphe non pondéré.  
    C’est possible car le BFS explore tous les nœuds voisins au niveau courant avant de passer au niveau suivant, garantissant ainsi que le premier chemin trouvé pour atteindre un nœud est le plus court.
1. **L’exhaustivité**  
    Le BFS explore de manière exhaustive tous les nœuds accessibles à partir du nœud de départ.  
    Très utile pour résoudre des problèmes nécessitant de visiter tous les nœuds, comme la détermination de la connectivité d’un graphe.
1. **La simplicité d’implémentation**  
    Le BFS a une implémentation relativement simple, basée sur l’utilisation d’une file d’attente pour garder une trace des nœuds à visiter.  
    Le rendant facile à comprendre et à mettre en œuvre par rapport à d’autres algorithmes de parcours plus complexes.
1. **L’utilisation de la mémoire**
    Il a un espace mémoire requis proportionnel à la taille du graphe, car il doit stocker tous les nœuds à visiter dans la file d’attente.  
    Le rendant plus efficace en termes d’utilisation de la mémoire que des algorithmes comme le DFS (Depth-First Search) pouvant nécessiter un espace mémoire proportionnel à la profondeur du graphe.
1. **Parallélisation possible**  
    Cet algorithme prête bien à une parallélisation, car l’exploration des nœuds voisins peut être effectuée de manière indépendante.  
    Intéressant pour les architectures multiprocesseurs ou multi-cœurs.

_**⟹ Le BFS est un algorithme simple, efficace et exhaustif, particulièrement adapté pour trouver le plus court chemin dans un graphe non pondéré et déterminer la connectivité d’un graphe. Ses avantages en font un algorithme très utilisé dans de nombreuses applications.**_
## **Les principaux inconvénients**
1. **La consommation mémoire**  
    Le BFS requiert l’utilisation d’une file d’attente pour stocker tous les nœuds à visiter.  
    Pouvant entraîner une consommation mémoire plus importante pour des graphes de grande taille, par rapport à des algorithmes comme le DFS (Depth-First Search) qui ont un espace mémoire proportionnel à la profondeur du graphe.
1. **L’inefficacité pour les graphes pondérés**  
    Il n’est pas très efficace pour trouver le plus court chemin dans un graphe pondéré.  
    Le BFS ne tient pas compte des poids des arêtes et explore les nœuds niveau par niveau, ce qui peut mener à des chemins non optimaux.  
    Dans ce cas, l’algorithme de Dijkstra serait plus approprié pour trouver le plus court chemin.
1. **La omplexité temporelle moins favorable**  
    La complexité temporelle du BFS est en O(|V| + |E|), où |V| est le nombre de nœuds et |E| le nombre d’arêtes.  
    Certains algorithmes comme le DFS ont une complexité temporelle plus favorable en O(|V|) dans certains cas.
1. **Difficulté pour les graphes infinis ou très grands**  
    Le BFS peut avoir du mal à traiter des graphes infinis ou extrêmement grands, car la file d’attente peut devenir trop importante.  
    Dans ces cas, des approches plus sophistiquées, comme l’utilisation d’heuristiques, peuvent être nécessaires.
1. **Manque de flexibilité dans l’ordre de visite**  
    Avec le BFS, l’ordre de visite des nœuds est déterminé par la structure de la file d’attente.  
    Pouvant être une limitation pour certaines applications où un ordre de visite spécifique est nécessaire, comme dans le cas de l’algorithme de Kahn pour le tri topologique.

_**⟹ Malgré ces inconvénients, le BFS reste un algorithme très utile et largement utilisé, notamment pour ses performances dans la recherche du plus court chemin dans des graphes non pondérés et pour la détermination de la connectivité des graphes. Le choix de l’algorithme de parcours dépendra des besoins spécifiques de l’application.**_
## **À quels types de problèmes le BFS est-il particulièrement adapté et efficace ?**
1. **La recherche du plus court chemin dans des graphes non pondérés**  
    Comme mentionné précédemment, l’algo BFS permet de trouver le plus court chemin entre un nœud de départ et n’importe quel autre nœud accessible dans un graphe non pondéré.  
    Très utile pour résoudre des problèmes de navigation, de planification de trajet, etc. dans des environnements modélisés par des graphes non pondérés.
1. **Détermination de la connectivité d’un graphe**  
    Explore exhaustivement tous les nœuds accessibles à partir d’un nœud de départ.  
    Permetant de détecter si un graphe est connexe (tous les nœuds sont accessibles) ou déconnecté (certains nœuds ne sont pas accessibles).  
    Cette propriété le rend bien utile pour analyser la structure de graphes représentant des réseaux sociaux, des réseaux informatiques, des molécules, etc.
1. **Résolution de problèmes de labyrinthe ou de parcours de graphe**  
    De nombreux problèmes impliquant la traversée d’un labyrinthe ou d’un graphe peuvent être résolus efficacement à l’aide du BFS.  
    E.g. : trouver le chemin le plus court dans un labyrinthe, déterminer si deux nœuds sont connectés dans un graphe, etc.
1. **Implémentation d’algorithmes de tri topologique**  
    Bien que le DFS soit plus couramment utilisé pour le [tri topologique](), le BFS peut également être utilisé pour résoudre ce type de problème.  
    Le BFS permet de visiter les nœuds dans un ordre respectant les dépendances entre eux.
1. **Calcul de mesures de centralité dans les réseaux**  
    Le BFS peut être utilisé pour calculer des mesures de centralité dans les graphes, comme la centralité de proximité (closeness centrality).  
    Ces mesures sont utiles pour identifier les nœuds les plus importants ou influents dans un réseau.

_**⟹ Il est particulièrement adapté aux problèmes nécessitant une exploration exhaustive d’un graphe, la détection de la connectivité, la recherche de plus courts chemins dans des graphes non pondérés, ainsi que la résolution de problèmes de labyrinthe ou de parcours de graphe.   
Son implémentation simple et son efficacité en font un algorithme très utilisé dans de nombreuses applications.**_

## **`BFR` versus `A*`**
BFS | A*
---|---
