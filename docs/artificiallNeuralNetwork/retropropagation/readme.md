# **Rétropropagation**

Rappel : ça commence par les variables qui sont propagées de la couche d'entrée à la couche cachée, finalement ressort une prédiction (appelée y chapeau) qui est comparée à la vrai valeur (y), avec une fonction de coût, résulte un coût, une erreur et avec cette info ce fait la propagation arrière (rétropropagation) afin d'ajuster les poids selon un algo du gradient ou un algo du gradient stochastique.  

Il est important de retenir que tous les poids sont ajustés en même temps (manuellement les poids seraient à jour un à un) en fonction de son influence sur l'erreur. C'est pourquoi l'algo était si populaire dès les années 80[¹].  

## Récapitulatif des étapes d'entraînement d'un réseau de neurones

Step 1 : Initialiser les poids avec des valeur proches et différentes de 0 ;  
Step 2 : Envoyer la première observation (premier individu) au tableau de données à la couche d'entrée avec une variable par neurone ;  
Step 3 : Propagation : les neurones sont activés inhéremment aux poids qui leur sont attribués. Proche de 0 le signal est faible, plus le poids est élevé, plus ne neurone est activé. Ainsi sont propagée les activations neuronales afin de traverser et obtenir la prédiction (y^) ;  
Step 4 : La prédiction est comparée à la vraie valeur `y` pour mesurer l'erreur via la fonction de coût choisi au préalable. ;  
Step 5 : La rétropropagation (de droite à gauche). L'erreur se repropage au réseau et mettre à jour les poids selon leur responsabilité dans l'erreur. Le taux d'apprentissage détermine de combien on ajuste les poids. ;  
Step 6 : Réitérer les étapes 1 à 5 ajustant les poids à chaque observations (c'est l'apprentissage renforcé, soit avec l'algo du gradient stochastique, ou par lot, ou mini lot) ;
Step 7 : Lorsque que tout le jeu de donnée à traverser l'ANN, ça fait une époque. À chaque époque le réseau s'améliore.  

___
>>> cf.  
    [¹] [Neural Network and Deep Learning](https://neuralnetworksanddeeplearning.com/chap2.html "Chap2 from the book of Michael Nielsen") explique comment sont ajoutés tous els poids dans le processus de retroprapagation.