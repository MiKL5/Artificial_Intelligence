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