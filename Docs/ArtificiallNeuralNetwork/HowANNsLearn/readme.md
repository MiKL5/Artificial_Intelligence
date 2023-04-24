# **Comment apprennent les réseaux de neurones artificiels** step by step

Il y a deux manières de pour qu'un programme fasse ce que l'on veut. On peut le coder en lui donnant les instructions à suivre étape par étape. Ou créer un système, ou le programme comprend tout ce qu'il doit faire.  

Typiquement, on donne des variables d'entrées à un réseau de neurones. Il faut coder chaque état : 
1. en commençant par créer un réseau de neurones ;
2. puis, on lui donne ce que l'on veut en sortie ;
3. on lui donne un processus, c'est une sorte de système ;
4. l'agent se débrouille pour trouver comment optimiser le système et apporter la sortie demandée.

L'objectif est de créer ce système qui apprend sans qu'on lui impose de règle.  

Selon la première méthode, si on voulait qu'un système face la différence entre un chien et un chat, il faudrait toutes les caractéristiques d'un chat, puis d'un chien, dans les moindres détails, en code. C'est le développeur qui enseigne comment reconnaître un chat d'un chien.

Avec un réseau de neurones, il y a juste besoin de coder l'architecture d'un système, puis lui fournir plein d'images déjà catégorisées, l'agent sait donc si c'est un chat ou un chien. Il lui reste à apprendre de lui-même. Il saura grâce à son apprentissage reconnaître un chat ou un chien avec les prochaines images non catégorisées. 

<div align="center">
    <img src="..\..\img\percepteurRond.png" alt="Percepteur rond" title="Réseau de neurones à propagation avant à une couche">
</div>

Cette structure, assez simple, est un `percepteur rond` ou aussi un `réseau de neurones à propagation avant à une couche`. À gauche, la couche d'entrée, au milieu un neurone caché, et à droite, une prédiction (ce n'est pas la vraie valeur). On reconnaît la prédiction grâce à l'accent circonflexe sur le y. Le simple y représente la vraie valeur.  
Le percepteur rond date de 1957, inventé par Frank Rosenblatt. Son idée était de créer un système qui apprend et s'auto-ajuste.  
Les entrées sont appliquées directement sur le réseau, puis s'applique la fonction d'activation et enfin la valeur de sortie qui sera comparée à la vraie valeur pour savoir si elle est proche en appliquant une valeur de coût. L'objectif est de minimiser la fonction de coût. Une fois le parangon fait, l'info fait le chemin inverse dans le réseau de neurones grâce aux synapses et l'agent met à jour les poids, car c'est la seule variable d'ajustement sur laquelle l'agent a le contrôle. La fonction d'activation est la / les valeurs d'entrées sont des constantes. Seuls les poids sont variables afin d'ajuster la valeur de sortie au plus proche de la vraie valeur.  

Le fait d'entraîner le réseau sur tout le jeu de données (chaque ligne (itération) d'un tableau) s'appelle une époque. Chaque itération au même réseau de neurones. Ce processus de base s'appelle la rétropropagation puisse que la première étape de l'ANN est la propagation (de gauche à droite) puis se retropropage pour mettre à jour les poids.

___
+ sur   
[Les réseaux de neurones](https://www.aspexit.com/reseau-de-neurones-on-va-essayer-de-demystifier-un-peu-tout-ca-1/)  
[Les fonctions de coûts](https://stats.stackexchange.com/questions/154879/a-list-of-functions-used-in-neural-netwarks-alongside-applications)