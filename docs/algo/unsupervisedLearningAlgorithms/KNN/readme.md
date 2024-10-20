# **L’algorithme KNN (K Nearest Neighbors)**
Cet algo d’apprenstissage non supervisé dont les plus proches voisins sont [KNN](../KNN) est une classificateur _d’apprentissage non supervisé_ s’appuiyant sur la notion de proximité pour réaliser des classification ou des prédictions sur le regroupement d’un point de données.

C’est une méthhode de classification parmi les plus simple et plus utilisée actuellmen en ML.

Utilisable pour la régression ou la classification, il est généralement employé pour la classification.

À la résolution de la classification, une étiquette de classe est attribuée à travers un vote de majorité (techniquement vote de pluratlité). C’est-à-dire que l’étiquette la plus rerésentée autour des points de données est utilisée.

Le « vote de majorité » requiert une majorité supérieure à 50 %, atteignable en principe lorsqu’il n’y a que deux catégories ; lorsqu’il y a plusieurs classes, (e.g. 4 catégories), recueillir 50 % n’est pas indispensable pour tirer des conclusions à propos d’une classe, et étiquetter une classe avec un vote supérieur à 25% 


___
> Cf.  
> [IBM; Qu’est-ce que l’algorithme des k plus proches voisins (KNN) ?](https://www.ibm.com/fr-fr/topics/knn#:~:text=L'algorithme%20des%20k%20plus%20proches%20voisins%20(KNN)%20est,d'un%20point%20de%20donn%C3%A9es.)
> [Université du Winsconsin-Madison, vote de pluralité vs vote de majorité](https://sebastianraschka.com/pdf/lecture-notes/stat479fs18/02_knn_notes.pdf)
> [DataScientest](https://datascientest.com/knn)