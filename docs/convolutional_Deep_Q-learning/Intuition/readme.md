# **Q-learning profond à convolution**

Il s’agit d’un réseau de neurones avec des étapes de convolution (pooling et floating).  
Le réseau considère des images avec des pixels avec différents niveaux de couleurs.  
L’image passe dans une couche de convolution et une couche de pooling puis une étape de floating pour obtenir le vecteur de la couche d’entrée de ce réseau de neurones.  
Ce qui permet de gérer des environnements complexes.  

Donc au lieu d’avoir un vecteur d’information, l’agent considère tout simplement chaque pixel de l’image (les niveaux de couleurs) afin d’apprendre à reconnaître les éléments qui la constituent. L’agent peut ainsi apprendre à reconnaître les murs, les ennemis, les chemins et cætera, afin d’évoluer dans un environnement en imitant au mieux le comportement humain.


__
> [Convolutional Neural Network : Tout ce qu’il y a à savoir](https://datascientest.com/convolutional-neural-network) Datascientest.com