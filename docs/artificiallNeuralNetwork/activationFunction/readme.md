# **Fonction d'activation**<a href="../../"><img src="../../../assets/images/atomicAi.png" alt="L'intelligence artificielle" align="right" height="64px"></a>

Les valeurs d'entrées sont des variables du jeu de données. Les synapses et leurs poids les relient a.ux couche.s neurones cachés qui appliquent une certaine fonction d'activation. Le résultat est envoyé au neurone suivant jusqu'à la valeur de sortie.  

Il y a plusieurs types de fonctions d'activation.  

## La fonction `Seuil`  

En abscisse (x), il y a le signal qui émane des synapses, c'est la somme des signaux pondérés par les poids.  
En ordonnée (y), la sortie de la fonction d'activation, envoyée au neurone suivant.  

    Elle renvoie 0 si le signal d'entrée est négatif et 1 s’il est positif. Utile quand il n'y a pas besoin de probabilté.

## La fonction `sigmoïde`

Elle est utilisée en régression logistique. Elle est très similaire à la fonction seuil, sauf qu'elle est plus lisse, car elle ne passe pas soudainement de 0 à 1.  
Avec cette fonction, à mesure qu'on se rapproche de 0, ça va augmenter et se rapprocher de 1, puis de plus en plus doucement se rapprocher de 1.

    Elle est très pratique dans la dernière couche, car elle permet de sortir une probabilité afin de décider.

## La fonction `redresseur`

C'est l'une des fonctions les plus populaires (énormément utilisée) dans les réseaux de neurones artificiels.  
* Si la somme des signaux est inférieure à 0, elle va renvoyer 0, donc coupé le signal.  
* Si la somme de X est supérieure ou égale à 0, elle renvoie `X` le signal sans l'altérer.

## La tangente `hyperbolique` (tanh)[¹]

Elle ressemble un petit peu à la fonction sigmoïde, et va rentrer dans les négatifs. Elle va de -1 à 1.

    Elle est utile dans les situations où il n'y a pas forcément de probabilités à ressortir.

___
Si la sortie est binaire, il y a 2 possibilités. Il est possible d'utiliser la fonction seuil ou la fonction sigmoïde (s'il faut une décision). 

S'il y a plusieurs valeurs d'entrées vers un grand réseau de neurones cachés, la fonction redresseur s'applique pour décider si le signal passe, puis, la fonction sigmoïde pour obtenir une probabilité.
___
[¹] [Deep spare rectifier neural networks](https://proceedings.mlr.press/v15/glorot11a/glorot11a.pdf)