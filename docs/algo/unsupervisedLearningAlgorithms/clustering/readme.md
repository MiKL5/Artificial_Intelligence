# **Le clustering** <a href="../../../"><img src="../../../../assets/images/ai1.png" alt="Les intelligences artificielles" align="right" height="64px"></a>
Les algorithmes non supervisés repèrent des similarités dans les données pour pouvoir ensuite les structurer. Par exemple ils peuvent étudier les similarités entre individus, ce qui rend possible leur division en différents groupes. Ce partitionnement des individus est appelé clustering.

Il y a 3 méthodes à connaître.
## **Le fonctionnement des méthodes de clustering**
Tant que l’intelligence artificielle des ordinateurs était incapable de détecter des similarités entre individus, ce sont bien des humains qui ont implémenté les algorithmes de clustering.

Il en existe plusieurs dizaines ; voici plusieurs grandes catégories.
Pour chaque méthode, il est nécessaire de choisir comment mesurer la similarité entre deux individus – imaginable comme deux points de l’espace des réels en dimension p.

Une fonction distance est nécessaire, (e.g. : la distance euclidienne). Les n individus sont des « points » de l’espace de variables R en dimension p.
## **Les méthodes de clustering hiérarchiques**
Leurs différences vient de fait de former pas-à-pas des connexions entre individus (pour les méthodes ascendantes de clustering hiérarchique), puis utilisent une matrice de distances entre individus pour trouver le regroupement le plus proche d’un autre.

Dans la pratique, partant d’n ensembles étants les individus singletons (1 seul élément) ; la première connexion se fait entre les individus les plus proches.

La deuxième étape débute par la mise à jour de la matrice des distances en retirant une case, en regroupant 2 individus. Nonobstant, comment calculer la distance d’un ensemble à un autre s’il n’est pas un singleton ? Dès le départ, c’est un choix à faire : _la stratégie d’agrégation_. Il y a de nombreuses méthodes de clustering hiérarchique : les plus simples étant de choisir la distance minimale entre les individus des deux groupes (single linkage ⟶ clustering à lien unique), maximale (complete linkage ⟶ lien complet) ou bien moyenne (average linkage ⟶ lien moyen)

À la fin de l’étape, les 2 groupes les plus proches sont connectés. Idem aux étapes suivantes. Cela s’arrête lorsque les 2 derniers groupes recouvrant tous les individus soient connectés.

Les connexions successives se représentent sur un dendrogramme et la distance associée à chaque connexion est su l’axe des ordonnes (Y).

C’est par le choix des clusters que se termine l’algo. Là aussi, il y a plusieurs critères (soit un nombre précis, ou un critère de distance interclasse). C’est le dendrogramme qui permet de mettre en évidence les clusters.
## **Les méthodes centroïdes**
La méthode centroïde la plus classique est la méthode des [k-moyennes](https://www.intelligence-artificielle-school.com/ecole/technologies/k-means-algorithme/) nécessitant un seul choix de départ : k, le nombre de classes voulues.

L’algorithme est initialisé avec k points au hasard parmi les n individus, représentant les k classes à la première étape. Sont ensuite associés les n-k points restants à la « classe-point » étant la plus proche. In finæ, chaque classe est caractérisée par la moyenne des valeurs de chacun de ses individus ; il y a k moyennes pour k classes.

La seconde étape, est d’évaluer la distance de chaque individu à chacune des k means. Certains individus peuvent ici changer de classe. A la fin de cette étape, on actualise les k means.Les étapes se réotèrent, jusqu’à la convergence et l’obtention des k clusters finaux.

Ces classes finales dépendent souvent beaucoup des k individus choisis pour l’initialisation. C’est pourquoi certains algorithmes de k-means itèrent plusieurs fois le processus avec des initialisations différentes, afin de garder la partition qui minimise le plus la variance intra-classe (somme des distances entre les individus d’une même classe).
## **Les méthodes à densité**
Les classes des méthodes à densité correspondent aux zones de densité relativement élevées ; beaucoup de points sont proches par rapport à d’autres zones de l’espace R en dimension p.

La méthode phare de cette catégorie est appelée DBSCAN (density-based spatial clustering of applications with noise). En formant des classes d’individus, l’algorithme repère les valeurs hors du commun que l’on qualifie de bruit.

Il prend deux paramètres en entrée : `Ɛ` la distance maximale qui peut définir deux individus comme voisins, et `N` le nombre minimal d’individus nécessaires pour former un groupe. À partir de là, l’algorithme est assez intuitif. Deux informations sont stockées : les clusters successifs et les individus visités au fur et à mesure.

La première étape consiste à choisir un point parmi les `n` disponibles. Grâce au paramètre `Ɛ`, on peut définir le voisinage du point initial.
* Avec le paramètre N, si cet ensemble est constitué de moins de N points, alors le point initial correspond à du bruit ; stocker dans les individus visités.
* À l’inverse si le voisinage comprend plus de N points ; un cluster est initialisé avec le point de départ. Chaque point de son voisinage initial est étudié.

Et pour tout point de ce voisinage, si son propre voisinage comporte plus de N éléments ; le voisinage initial est étendu en le réunissant avec le voisinage du point visité.  
Ce point est ajouté dans le cluster. Une fois que tous les points du voisinage sont testés, ceux retenus dans le cluster sont stockés comme individus visités. Et le cluster obtenu est stocké dans la liste des clusters.

Tant que tous les individus n’ont pas été visités, cette étape est réitérée en commençant par choisir un individu parmi ceux qui sont encore disponibles. Finalement la liste de groupes d’individus est obtenue ainsi que les individus correspondant à du bruit.
## **Les autres méthodes**
D’autres méthodes moins intuitives existent, comme la maximisation de l’espérance, qui repose sur des outils mathématiques probabilistes.  
Une multitude de façons de partitionner la population d’une base de données existe. Chaque méthode présente des avantages et limites, selon le type de données à traiter.

Les méthodes hiérarchiques peuvent être gourmandes en calculs, la méthode des k-means donne des groupes à la forme uniquement convexe, et pour chaque méthode les paramètres d’initialisation ne sont pas forcément optimaux… Sachant cela, l’objectif reste de minimiser les variances intra-classes en s’évitant des temps de calcul trop contraignants.  
Le but est d’obtenir de bons clusters ?

Le partitionnement s’avère très utile pour explorer une base de données, mais il sert également à de nombreux domaines : comme par exemple dans [la classification de données sonores](https://larevueia.fr/approche-mathematique-pour-le-traitement-et-le-clustering-des-donnees-sonores).  
Lorsque les données sont labellisées, la classification avec des réseaux de neurones est possible. Ces méthodes sont beaucoup plus efficaces, surtout lorsqu’il y a beaucoup de données. [Elles ont aussi leurs contraintes…](https://larevueia.fr/comprendre-les-réseaux-de-neurones/).

___
Cf.  
[Le clustering](https://larevueia.fr/clustering-les-3-methodes-a-connaitre/)  
[La classification de données sonores](https://larevueia.fr/approche-mathematique-pour-le-traitement-et-le-clustering-des-donnees-sonores)  
[Les réseaux de neurones](https://larevueia.fr/comprendre-les-réseaux-de-neurones/)