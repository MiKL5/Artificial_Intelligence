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
1. La détection du plus court chemin :  
    Le BFS permet de trouver le plus court chemin entre le nœud de départ et n’importe quel autre nœud accessible dans un graphe non pondéré.  
    C’est possible car le BFS explore tous les nœuds voisins au niveau courant avant de passer au niveau suivant, garantissant ainsi que le premier chemin trouvé pour atteindre un nœud est le plus court.
1. L’exhaustivité :  
    Le BFS explore de manière exhaustive tous les nœuds accessibles à partir du nœud de départ.  
    Très utile pour résoudre des problèmes nécessitant de visiter tous les nœuds, comme la détermination de la connectivité d’un graphe.
1. La simplicité d’implémentation :  
    Le BFS a une implémentation relativement simple, basée sur l’utilisation d’une file d’attente pour garder une trace des nœuds à visiter.  
    Le rendant facile à comprendre et à mettre en œuvre par rapport à d’autres algorithmes de parcours plus complexes.
1. L’utilisation de la mémoire :
    Il a un espace mémoire requis proportionnel à la taille du graphe, car il doit stocker tous les nœuds à visiter dans la file d’attente.  
    Le rendant plus efficace en termes d’utilisation de la mémoire que des algorithmes comme le DFS (Depth-First Search) pouvant nécessiter un espace mémoire proportionnel à la profondeur du graphe.
1. Parallélisation possible :
    Cet algorithme prête bien à une parallélisation, car l’exploration des nœuds voisins peut être effectuée de manière indépendante.  
    Intéressant pour les architectures multiprocesseurs ou multi-cœurs.

_**⟹ Le BFS est un algorithme simple, efficace et exhaustif, particulièrement adapté pour trouver le plus court chemin dans un graphe non pondéré et déterminer la connectivité d’un graphe. Ses avantages en font un algorithme très utilisé dans de nombreuses applications.**_