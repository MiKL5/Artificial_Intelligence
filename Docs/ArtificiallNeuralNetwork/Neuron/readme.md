# **Le neurone**

L'intérêt du neurone est l'apprentissage.   

Un neurone est constitué d'un corps cellulaire (le péricaryon) avec des branches (les dendrites) et une longues queue (l'axone).
<div align="center">
    <img src="../../img/neurone.avif" alt="Neurone" title="Neurone">
</div>

Les dendrites reçoivent les signaux, alors que l'axone envoi les signaux ; la force du neurone c'est leur nombre. Les neurones ne se touchant pas, ce sont les synapses que font la connexion.  
En informatique, il y a un neurone principal (le nœud), plusieurs signaux d'entrée (les dendrites) et un signal de sortie (l'axone). On parlera de synapse qui représente les connexions entre les neurones et de valeur au lieu des signaux.  
Pour schématiser la structure de la base des valeurs passent aux neurones principaux par les synapses, puis en ressort une prédiction.  

Les variables d'entrée sont des variables indépendantes. C'est toutes les variables du jeu de données. Il s'agit d'une seule observation. Par exemple l'observation d’une personne dont on va avoir :

* `x1` : son âge ;
* `x2` : ses revenus ;
* `x3` : sa localisation ; 
* etc.  

Il est de fait très important de standardiser les variables d'entrée. À savoir, retirer la moyenne, puis diviser par l'écart de manière à avoir des variables de moyenne zéro et d'écart type 1. Il est également possible de normaliser les variables avec une échelle de 0 à 1 (en retirant la valeur minimale et en divisant la différence entre le maximum et le minimum). Il faut savoir comment choisir l'un ou autre. **L'important est que toutes les variables soit sur la mêmes échelles car ce sera beaucoup plus facile pour le réseau de neurone[¹].** 

Il y a aussi une valeur de sortie nommée `Y` qui peut avoir 3 composantes : 
* elle peut être continue (ex : si l'agent essai de prédire un prix) ;  
* Une variable binaire (ex : est-ce une fraude) ;  
* une variable catégorique, c-à-d plusieurs groupes possibles.
Au final, il n'y a qu'une seule valeur de sortie.  

    Schématiquement, c'est la même observation à gauche et à droite des variables indépendantes à l'entrée, puis par régression, 1 sortie.

Chaque synapse à un poids (W1, W2, et cætera). Le poids des synapses est fondamentale car il permet au réseau de neurone d'apprendre. En ajustant le poids l'algo décide le niveau d'importance des variables et quel signal peut passer en ajustant le poids de chacune des variables. Le but est d'ajuster les poids de la façon la plus optimale pour trouver la meilleure combinaison. 

Tous ces signaux vont entrer les neurones principaux. La première est d'additionner tous ces signaux qui sont chacun pondérés par leur propre poids. Un signal au poids nul ne passe pas, alors qu'un signal avec un poids très lourd prend bcp d'importance à cette étape.  
Ensuite, l'agent applique la fonction d'activation à la somme de tout qu'il y avait à l'étape précédente. Elle est assignée à la couche de neurones principales.
Puis, selon la fonction, le signal passe à la couche de neurones de sortie, parfois à une autre couche cachée (intermédiaire) de neurones (ce qui réitérerait un processus similaire jusqu'à la valeur de sortie).  

> En résumé :  
La première couche de neurones sont les variables d'entrées. Reliées à des couches (intermédiaires) cachées par des synapses qui vont assignées un poids afin de déterminer l'importance du signal. À l'intérieur de chaque neurone s'applique une fonction d'activation. Après cette fonction le signal passe à la couche suivante. Ce qui peut être appliqué des centaines voire des milliers de fois selon la taille du réseau de neurone. Et à la toute fin, la prédiction.
___
[¹] [Efficient BackProp](https://yann.lecun.com/exdb.public/pdf/lecun-98b.pdf) Cet article explique l'importance de la normalisation des variables avant d'entraîner les réseaux de neurones.