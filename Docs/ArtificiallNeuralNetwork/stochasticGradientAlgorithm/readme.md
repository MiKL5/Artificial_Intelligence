# **L'algorithme du gradient stochastique**

La fonction de coût n'est jamais une courbe parfaite (convexe). Dans la pratique, elle peut monter et descendre à plusieurs endroits.  
L'agent peut tomber sur un minimum local mais pas global (le meilleur).  

L'**algorithme du gradient stochastique** s'affranchi de l'hypothèse de convexité.  

Dans la rétropropagation, l'agent prend toutes les lignes et obtient rendement estimé (y^) comparé avec (y), applique la fonction de coût et rétro propage le tout pour ajouter les points. C'est l'**algorithme du gradient par lot**. C'est à dire prendre toutes les lignes calculer la fonction de coût et ajuster tous les poids d'un coût.

L'algorithme du gradient stochastique la première ligne est envoyée au réseau de neurones pour calculer directement un coût et les poids sont ajuster tout de suite pour cette première ligne. Idem pour la deuxième. Les poids sont donc ajustés après chaque ligne et ça évite de tomber sur les minimums locaux car cet algo à beaucoup plus de fluctuation avec les poids, par conséquent beaucoup plus de probabilité de tomber sur le minimum global. Et même si ça semble contre-intuitif car les poids sont réajustés à chaque ligne, mais c'est plus rapide, mais ça vient du fait qu'il n'y a pas besoin de charger tout le jeu de données en mémoire, ni d'attendre que toutes les lignes passent dans le réseau pour ajuster les poids, et le processus et nécessite beaucoup moins de temps de calcul.  

L'_algorithme du gradient par lot est déterministe_. Si on démarre toujours avec les mêmes poids, on a les mêmes résultats à la fin. Ce n'est pas forcément le cas avec l'_algo du gradient stochastique_. C'_est aléatoire_, en démarrant avec les mêmes poids, les lignes sont sélectionnées dans un ordre aléatoire du coût à chaque passage au réseau de neurones le résultat peut changer.  

L'**algo par mini lot** est un mix des deux. Il consiste à ajuster les coûts après avoir lancé un sous ensemble de lignes (exemple : si il faut ajuster les poids toutes les 5 lignes). Ça permet d'avoir les avantages des deux algorithmes.

___
>> Cf.  
A Neural Network in 13 lines of Python [(Part 2 - Gradient Descent)](https://iamtrask.github.io/2015/07/27/python-network-part2)  
[Neural Network and Deep Learning](https://neuralnetworksanddeeplearning.com/chap2.html)