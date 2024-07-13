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
```stata
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